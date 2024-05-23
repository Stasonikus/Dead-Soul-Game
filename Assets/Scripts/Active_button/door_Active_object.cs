using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class door_Active_object : MonoBehaviour
{
    public static bool door_a;
    public void OnTriggerEnter2D(Collider2D player) 
    {
        if(player.CompareTag("Player"))
        {
            door_a = true;
        }
    }
    public void OnTriggerExit2D(Collider2D player) 
    {
        if(player.CompareTag("Player"))
        {
            door_a = false;
        }
    }
}
