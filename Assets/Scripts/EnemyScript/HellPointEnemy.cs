using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class HellPointEnemy : MonoBehaviour
{
    public int MaxhealthEN = 100;
    public float health;

    public void Start()
    {
        health = MaxhealthEN;
    }

   

    public void TakeDamage(float damageGG)
    {
        health -= damageGG;
        
        if (health <= 0)
        {
            Die();
        }
    }

    void Die()
    {
        Destroy(gameObject);
        Debug.Log("ÁÎËÜÍÎ Enemy");
    }

}
