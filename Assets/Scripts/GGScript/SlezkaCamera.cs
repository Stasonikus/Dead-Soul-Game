using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SlezkaCamera : MonoBehaviour
{
    public float dampTime = 0.15f;
    private Vector3 velocity = Vector3.zero;
    public Transform target;
    public float offsetx = 0f;
    public float offsety = 0f;
    public float otkl = 10f;
    public GameObject bg;
    public Joystick joystick;

    void FixedUpdate()
    {
        if (target)
        {
            float xpov = joystick.Horizontal;
            xpov *= otkl;
            Vector3 point = GetComponent<Camera>().WorldToViewportPoint(new Vector3(target.position.x, target.position.y + 0.75f, target.position.z));
            Vector3 delta = new Vector3(target.position.x + offsetx + xpov, target.position.y + 0.75f + offsety, target.position.z) - GetComponent<Camera>().ViewportToWorldPoint(new Vector3(0.5f, 0.5f, point.z)); //(new Vector3(0.5, 0.5, point.z));
            Vector3 destination = transform.position + delta;

            transform.position = Vector3.SmoothDamp(transform.position, destination, ref velocity, dampTime);
        }
        Vector3 posBG = new Vector3(bg.transform.position.x, bg.transform.position.y, bg.transform.position.z);
        posBG.x = Camera.main.transform.position.x + 1f;
        bg.transform.position = Vector3.SmoothDamp(bg.transform.position, posBG, ref velocity, 1f);
    }
}
