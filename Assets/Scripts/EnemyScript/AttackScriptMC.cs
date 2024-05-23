using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AttackScriptMC : MonoBehaviour
{
    public Animator animator;
    //для активного состояния скелета
    public float attackDamageEN = 0f;
    public float attackRate = 2f;
    private float nextAttackTime = 10f;
    //переменные для состояния когда скелет ПИЗДИТ ГГ
    public Transform attackPointEnemy;
    public float attackRangeEnemy = 0.5f;
    public LayerMask GGLayers;
    public ControlMC ControlMCReference;
    private float damageTimer = 1f;      // Таймер для уменьшения damage каждую секунду
    private float timeElapsed = 0f;     // Время, прошедшее с последнего уменьшения damage
    void Start()
    {

    }

// Update is called once per frame
    void Update()
    {
        // Обновление таймера
        timeElapsed += Time.deltaTime;

        attackRate++;
        //Debug.Log(attackRate);
    }
    public void Attack()
    {
        ControlMCReference.Povorot();
        Collider2D[] hitGG = Physics2D.OverlapCircleAll(attackPointEnemy.position, attackRangeEnemy, GGLayers);

        // Проверка, есть ли хотя бы один объект в триггере
        if (hitGG.Length > 0)
        {   

            // Перебираем все объекты в триггере
            foreach (Collider2D enemyCollider in hitGG)
            {
                // Получаем компонент HellPointGG у текущего объекта
                HellPointGG hellPointGG = enemyCollider.GetComponent<HellPointGG>();

                // Проверяем, что компонент HellPointGG существует
                if (hellPointGG != null)
                {
                    // Проверка, прошла ли секунда
                    if (timeElapsed >= damageTimer)
                    {
                        animator.SetTrigger("ATTACK");
                        enemyCollider.GetComponent<HellPointGG>().TakeDamage(attackDamageEN * Time.deltaTime);
                        // Сброс таймера
                        timeElapsed = 0f;
                    }
                }
            }
        }
    }
    private void OnDrawGizmosSelected()
    {
        Gizmos.DrawWireSphere(attackPointEnemy.position, attackRangeEnemy);
    }
}
