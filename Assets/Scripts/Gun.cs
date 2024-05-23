using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Gun : MonoBehaviour
{
    public GameObject bullet;
    public Transform shotPoint;

    private float timeBtwShots;
    public float starttimeBtwShots;

    private void Update()
    {
        if (timeBtwShots <= 0)
        {
            if (Input.GetKey(KeyCode.F))
            {
                Instantiate(bullet, shotPoint.position, transform.rotation);
                timeBtwShots = starttimeBtwShots;
            }
        }

        if (timeBtwShots <= 0)
        {
            if (Input.GetKey(KeyCode.G))
            {
                Instantiate(bullet, shotPoint.position, transform.rotation);
                timeBtwShots = starttimeBtwShots;
            }
        }

        else
        {
            timeBtwShots -= Time.deltaTime;
        }
    }
}
