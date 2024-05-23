using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class FillAmouthBlinck : MonoBehaviour
{
    public Image barBlink;
    public float BlinkT = 0f;
    public float MaxBlinck = 1f;
    public static bool Blinck;

    private void Start()
    {
        BlinkT = 0f;
    }

    private void Update()
    {
        if (CounterSoul.soulProverca == true) 
        {
            BlinkT += 0.5f * Time.deltaTime;
        }



        barBlink.fillAmount = BlinkT;
        if (BlinkT > MaxBlinck)
        {
            BlinkT = MaxBlinck;
        }
        if (BlinkT < 0)
        {
            BlinkT = 0;
        }
        if(Blink.blinkproverca && BlinkT >= MaxBlinck)
        {
            BlinkT = 0f;
        }
        if (BlinkT == MaxBlinck)
        {
            Blinck = true;
        }
        else
        {
            Blinck = false;
        }
    }
}
