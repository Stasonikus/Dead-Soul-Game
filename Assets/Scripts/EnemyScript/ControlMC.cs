using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ControlMC : MonoBehaviour
{
    public Animator animator;
    public GameObject Enemybody;
    public Rigidbody2D RB2DGG;
    public Rigidbody2D RB2DEN;
    public AttackScriptMC AttackScriptMCReference;
    //для активного состояния скелета
    public float enemySpeed;
    public float speed = 5f;
    private float EngrySpeed = 14;
    public float stoppingDistanse;
    //для пассивного состояния скелета
    private bool MovingRotation = false;
    private float SpeedRotation = 90f;
    private bool EnemyAttack = false;
    private int TimeSrav;
    private float freez = 2.0f; // Задержка в секундах
    //изначальные условия bool в коде
    bool chill;
    bool attack;
    //переменные для состояния когда скелет ПИЗДИТ ГГ
    public float AttackDistance;
    public LayerMask GGLayers;
    public Transform GGPlayer; //ячейка памяти для главного героя

    void Start()
    {
        //RB2DEN = GetComponent<Rigidbody2D>();
        animator = GetComponent<Animator>();
        TimeSrav = 0;
        GGPlayer = GameObject.FindGameObjectWithTag("Player").GetComponent<Transform>();                  //задаем условие слежики передвижения персонажа   
    }


    void Update()
    {
        //enemySpeed = RB2DEN.velocity.magnitude;
        //Vector2 currentVelocity = RB2DEN.velocity;
        //speedX = currentVelocity.x;

        if (Vector2.Distance(transform.position, GGPlayer.position) > stoppingDistanse)
        {
            animator.SetBool("RUN", false);
            Chill();
        }

        if (Vector2.Distance(transform.position, GGPlayer.position) < stoppingDistanse && EnemyAttack == false)                  // условия и методы действия enemy
        {
            animator.SetBool("RUN", true);
            Pursuit();                                                                      //условия атаки врагов
        }

        if (Vector2.Distance(transform.position, GGPlayer.position) < AttackDistance)
        { 
                EnemyAttack = true;
                AttackScriptMCReference.Attack();
                //Debug.Log("Attack");
        }
        else
        {
            EnemyAttack = false;
        }

        //Debug.Log(TimeSrav);
        TimeSrav++;
    }


    void Pursuit()
    {
        Povorot(); 
        transform.position = Vector2.MoveTowards(transform.position, GGPlayer.position, speed * Time.deltaTime);
       // animator.SetFloat("RUN", enemySpeed);
    }




    public void Povorot()
    {
        if (RB2DGG.position.x > RB2DEN.position.x)
        {
            RotateRight();
        }
        else if (RB2DGG.position.x < RB2DEN.position.x)
        {
            RotateLeft();
        }
    }
    private void RotateLeft()
    {
        Enemybody.transform.rotation = Quaternion.Euler(0, 180, 0);
    }

    private void RotateRight()
    {
        Enemybody.transform.rotation = Quaternion.Euler(0, 0, 0);
    }




    public void Chill()
    {

        if (TimeSrav == 600)
        {
            RotateLeft();

        }
        //корутина отдыха с циклом ожидания полторы секунды на каждую сторону
        else if (TimeSrav >= 1200)
        {
            RotateRight();
            TimeSrav = 0;
        }
    }
}