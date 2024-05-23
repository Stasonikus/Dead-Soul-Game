using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SlezkaCamera2 : MonoBehaviour
{
    public Transform target; // ссылка на персонажа, за которым камера будет следить
    public float smoothTime = 0.3f; // время, за которое камера догонит персонажа
    private Vector3 velocity = Vector3.zero;

    void FixedUpdate()
    {
        if (target != null)
        {
            // получаем позицию персонажа и позицию, в которой должна находиться камера
            Vector3 targetPosition = new Vector3(target.position.x, target.position.y, transform.position.z);
            Vector3 newPosition = Vector3.SmoothDamp(transform.position, targetPosition, ref velocity, smoothTime);

            // устанавливаем новую позицию камеры
            transform.position = newPosition;
        }
    }
}
