using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DamagePointMIN : MonoBehaviour
{
    public int collisionDamage = 50;
    public string collisionTag;

    public void OnCollisionEnter2D(Collision2D collision)
    {
        if(collision.gameObject.tag == collisionTag)
        {
            HellPointGG healthGG = collision.gameObject.GetComponent<HellPointGG>();
           // healthGG.TakeHit(collisionDamage);
        }
    }
}
