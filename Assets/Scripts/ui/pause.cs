using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class pause : MonoBehaviour
{
    public static bool gameispause = false;

    void Update()
    {
        if (gameispause == true)
        {
            Time.timeScale = 0f;
        }
        else
        {
            Time.timeScale = 1f;
        }
    }

    public void pauseOn()
    {
        gameispause = true;
    }
    public void pauseOff()
    {
        gameispause = false;
    }
}
