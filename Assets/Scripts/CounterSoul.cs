using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class CounterSoul : MonoBehaviour
{
    public TextMeshProUGUI soulText;
    public static float soul = 0f;
    public static bool soulProverca;

    private void Start()
    {
        
    }
    private void Update()
    {
        soulText.text = "0" + soul;
        if (soul >= 2)
        {
            soulProverca = true;
        }
        else
        {
            soulProverca = false;
        }
    }
}
