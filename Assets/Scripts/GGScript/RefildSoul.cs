using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RefildSoul : MonoBehaviour
{   public static bool refildproverka = false;
    public void Update()
    {
        if (refild_button.button_passivka == true && (FillAmmounthMANA.manaproverca == true) && (FillAmouthrefidlsoul.Passivka == true))
        {
            CounterSoul.soul += 1;
            if (FillAmmounthMANA.MANA >= 0.25f)
            {
                FillAmmounthMANA.MANA -= 0.25f;
            }
            FillAmouthrefidlsoul.PassivkaT = 0;
            refildproverka = true;
            
           
        }

        else
        {
            refildproverka = false;
        }

    }

}
