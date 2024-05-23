using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DamageZoneGG : MonoBehaviour
{
    public Transform DamagePoint;
    public float DamageRange = 0.5f;

    private void Update()
    {
       
        Physics2D.OverlapCircleAll(DamagePoint.position, DamageRange);
    }


    private void OnDrawGizmosSelected()
    {
        if (DamagePoint == null)
            return;

        Gizmos.color = Color.green;
        Gizmos.DrawWireSphere(DamagePoint.position, DamageRange);
    }
}
