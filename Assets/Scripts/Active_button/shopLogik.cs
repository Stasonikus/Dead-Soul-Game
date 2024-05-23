using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class shopLogik : MonoBehaviour
{
    public GameObject blink;
    public GameObject passivka;

    public GameObject blink_z;
    public GameObject passivka_z;
    public GameObject blink_button;
    public GameObject passivka_button;

    public void blink_eneble()
    {
        if(CounterSoul.soul >= 5f)
        {
            CounterSoul.soul -= 5f;
            ControlGG.blink_on = 1f;
        }
    }

    public void passivka_eneble()
    {
        if(CounterSoul.soul >= 7f)
        {
            CounterSoul.soul -= 7f;
            ControlGG.pasivka_on = 1f;
        }
    }
    void Start()
    {
        
    }


    void Update()
    {
        
    }
}
