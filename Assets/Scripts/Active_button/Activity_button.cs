using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Activity_button : MonoBehaviour
{   
    public GameObject shop;
    public GameObject ui;
    public void check()
    {
        if(door_Active_object.door_a == true)
        {
            if(SceneManager.GetActiveScene().buildIndex == 1)
            {
                door_Active_object.door_a = false;
                SceneManager.LoadScene(2);
                
            }
            else
            {
                door_Active_object.door_a = false;
                SceneManager.LoadScene(1);
                
            }
        }
        if(shope_Active_object.shop_a == true)
        {
            pause.gameispause = true;
            ui.SetActive(false);
            shop.SetActive(true);
        }
    }


}
