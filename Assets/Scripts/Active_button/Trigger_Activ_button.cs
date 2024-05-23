using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Trigger_Activ_button : MonoBehaviour
{
    public Animator Shop_button;
    public void OnTriggerEnter2D(Collider2D player) 
    {
        if(player.CompareTag("Player"))
        {
            Shop_button.SetBool("shop_button_open",true);
        }
    }
    public void OnTriggerExit2D(Collider2D player) 
    {
        if(player.CompareTag("Player"))
        {
            Shop_button.SetBool("shop_button_open",false);
        }
    }
}
