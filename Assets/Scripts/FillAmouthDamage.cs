using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class FillAmouthDamage : MonoBehaviour
{
    public Image healthBar;
    public HellPointGG player;

    private void Start()
    {
        healthBar = GetComponent<Image>();
        player = FindObjectOfType<HellPointGG>();
    }

    private void Update()
    {
        //healthBar.fillAmount = player.healthGG / player.maxHealt;
    }
}
