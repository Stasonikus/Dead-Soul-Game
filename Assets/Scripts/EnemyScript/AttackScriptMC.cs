using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AttackScriptMC : MonoBehaviour
{
    public Animator animator;
    //��� ��������� ��������� �������
    public float attackDamageEN = 0f;
    public float attackRate = 2f;
    private float nextAttackTime = 10f;
    //���������� ��� ��������� ����� ������ ������ ��
    public Transform attackPointEnemy;
    public float attackRangeEnemy = 0.5f;
    public LayerMask GGLayers;
    public ControlMC ControlMCReference;
    private float damageTimer = 1f;      // ������ ��� ���������� damage ������ �������
    private float timeElapsed = 0f;     // �����, ��������� � ���������� ���������� damage
    void Start()
    {

    }

// Update is called once per frame
    void Update()
    {
        // ���������� �������
        timeElapsed += Time.deltaTime;

        attackRate++;
        //Debug.Log(attackRate);
    }
    public void Attack()
    {
        ControlMCReference.Povorot();
        Collider2D[] hitGG = Physics2D.OverlapCircleAll(attackPointEnemy.position, attackRangeEnemy, GGLayers);

        // ��������, ���� �� ���� �� ���� ������ � ��������
        if (hitGG.Length > 0)
        {   

            // ���������� ��� ������� � ��������
            foreach (Collider2D enemyCollider in hitGG)
            {
                // �������� ��������� HellPointGG � �������� �������
                HellPointGG hellPointGG = enemyCollider.GetComponent<HellPointGG>();

                // ���������, ��� ��������� HellPointGG ����������
                if (hellPointGG != null)
                {
                    // ��������, ������ �� �������
                    if (timeElapsed >= damageTimer)
                    {
                        animator.SetTrigger("ATTACK");
                        enemyCollider.GetComponent<HellPointGG>().TakeDamage(attackDamageEN * Time.deltaTime);
                        // ����� �������
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
