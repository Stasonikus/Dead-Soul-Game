using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class FillAmmounthMANA : MonoBehaviour
{
    public Image barMANA;
    public static float MANA;
    public static float MANAmax = 1f;
    public static bool manaproverca;

    private void Start()
    {
        MANA = 0;
    }

    private void Update()
    {

        barMANA.fillAmount = MANA;


        if (MANA > MANAmax)
        {
            MANA = MANAmax;
        }
        if (MANA < 0)
        {
            MANA = 0;

        }
        if (MANA <= 0)
        {
            manaproverca = false;
        }

        if (MANA >= 0.25f)
        {
            manaproverca = true;
        }

        if (MANA >= 0.5f)
        {
            manaproverca = true;
        }

        if (MANA >= 0.75f)
        {
            manaproverca = true;
        }

        if (MANA == MANAmax)
        {
            manaproverca = true;
        }
    }
}