using UnityEngine;
using UnityEngine.UI;

public class stik : MonoBehaviour
{
    public Image bgImage;
    public Image joystickImage;
    public Vector2 inputVector;

    private Vector2 initialPosition;

    private void Start()
    {
        initialPosition = joystickImage.rectTransform.anchoredPosition;
    }

    private void Update()
    {
        if (Input.GetMouseButton(0))
        {
            Vector2 pos;
            if (RectTransformUtility.ScreenPointToLocalPointInRectangle(bgImage.rectTransform, Input.mousePosition, null, out pos))
            {
                pos.x = (pos.x / bgImage.rectTransform.sizeDelta.x);
                pos.y = (pos.y / bgImage.rectTransform.sizeDelta.y);

                inputVector = new Vector2(pos.x * 2 + 1, pos.y * 2 + 1);
                inputVector = (inputVector.magnitude > 1.0f) ? inputVector.normalized : inputVector;

                joystickImage.rectTransform.anchoredPosition = new Vector2(inputVector.x * (bgImage.rectTransform.sizeDelta.x / 3), inputVector.y * (bgImage.rectTransform.sizeDelta.y / 3));
            }
        }
        else
        {
            inputVector = Vector2.zero;
            joystickImage.rectTransform.anchoredPosition = initialPosition;
        }
    }

    public float Horizontal()
    {
        return inputVector.x;
    }

    public float Vertical()
    {
        return inputVector.y;
    }
}
