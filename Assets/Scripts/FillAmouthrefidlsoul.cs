using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class FillAmouthrefidlsoul : MonoBehaviour
{
    public Image barPassivka;
    public static float PassivkaT = 0f;
    public float MaxPassivka = 20f;
    public static bool Passivka;
    public static bool startrefildsoul;


    public void Start()
    {
        PassivkaT = 0f;
    }

    public void Update()
    {
        if (FillAmmounthMANA.manaproverca == true)
        {
            PassivkaT += 0.05f * Time.deltaTime;
        }



        barPassivka.fillAmount = PassivkaT;
        if (PassivkaT > MaxPassivka)
        {
            PassivkaT = MaxPassivka;
        }
        if (PassivkaT < 0)
        {
            PassivkaT = 0;
        }
        if (RefildSoul.refildproverka == true && PassivkaT >= MaxPassivka)
        {
            PassivkaT = 0f;
        }
        if (PassivkaT == MaxPassivka && FillAmmounthMANA.manaproverca)
        {
            Passivka = true;
        }
        else
        {
            Passivka = false;
        }
    }
    
}

