using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;


public class CounterGlasses : MonoBehaviour
{
    
    
    void OnTriggerEnter2D(Collider2D Soul)
    {
        if(Soul.CompareTag("Soul"))
        {
            FillAmmounthMANA.MANA+=0.1f;
            CounterSoul.soul += 1f;
            Destroy(Soul.gameObject);
        }
    }
}
