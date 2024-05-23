using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class shope_Active_object : MonoBehaviour
{
    public static bool shop_a;
    public void OnTriggerEnter2D(Collider2D player) 
    {
        if(player.CompareTag("Player"))
        {
            shop_a = true;
        }
    }
    public void OnTriggerExit2D(Collider2D player) 
    {
        if(player.CompareTag("Player"))
        {
            shop_a = false;
        }
    }
}
