using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HellPointGG : MonoBehaviour
{
    public float MaxhealthGG = 100;
    public float health;

    public void Start()
    {
        health = MaxhealthGG;
    }



    public void TakeDamage(float damageEN)
    {
        health -= damageEN;

        if (health <= 0)
        {
            Die();
        }
    }

    void Die()
    {
        Destroy(gameObject);
        Debug.Log("ÁÎËÜÍÎ GG");
    }
}
