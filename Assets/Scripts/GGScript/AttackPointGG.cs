using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AttackPointGG : MonoBehaviour
{
    public Animator AttackAnim;

    public float attackDamageGG = 1f;
    public Transform AttackPoint;
    public float AttackRange = 0.5f;
    public LayerMask Enemy;

    private void Update()
    {

        if (attack_button.attacknp == true)
        {         
            Attack();
        }
    }

    void Attack()
    {    
        //запуск анимации атаки;   
        attack_button.attacknp = false;
        OnAttack();
        AttackAnim.SetTrigger("Attack");
    }


    void OnAttack()
    {
        //определение врагов в зоне видимости;
        Collider2D[] hitEnemies = Physics2D.OverlapCircleAll(AttackPoint.position, AttackRange, Enemy);
        
        //Дамаг нефорам;
        foreach (Collider2D GGCollider in hitEnemies)
        {
            AttackScriptMC hellPointEN = GGCollider.GetComponent<AttackScriptMC>();
            if (hellPointEN != null)
            { 
                GGCollider.GetComponent<HellPointEnemy>().TakeDamage(attackDamageGG);
                Debug.Log("Обнаружен");
            }
        }
    }

    private void OnDrawGizmosSelected()
    {
        if (AttackPoint == null)
        return;
        Gizmos.color = Color.red;
        Gizmos.DrawWireSphere(AttackPoint.position, AttackRange);
    }

}

