using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Blink : MonoBehaviour
{
    public float teleportDistance = 10f; 
    private bool facingRight = true;
    public static bool blinkproverca;
    public Joystick joystick;

    private void Update()
    {
        double moveDirection = joystick.Horizontal;

        if (moveDirection > 0 && !facingRight)
        {
            Flip();
        }
        else if (moveDirection < 0 && facingRight)
        {
            Flip();
        }

        if (blimk_button.blinkknp == true && (FillAmouthBlinck.Blinck) &&(ControlGG.isObjectDetected == false))
        {
            MoveForward();
            CounterSoul.soul -= 2f;
            blinkproverca = true;
            blimk_button.blinkknp = false;
        }

        else
        {
            blinkproverca = false;
            blimk_button.blinkknp = false;
        }

       
    }

    
    public void MoveForward()
    {
        float direction = facingRight ? 1f : -1f;
        Vector3 newPosition = transform.position + new Vector3(teleportDistance * direction, 0f, 0f);
        transform.position = newPosition;
    }

    

    private void Flip()
    {
        facingRight = !facingRight;
        transform.Rotate(Vector3.up, 180f, Space.Self);
    }
}
