using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ControlGG : MonoBehaviour
{
    //Аниматор
    public Animator animator;

    //Атака
    public static bool isObjectDetected;
    private float RaycastDistanse = 15f;
    public string collisionTagGround;
    //Интерфейс
    Rigidbody2D rb;
    Rigidbody2D rb2;
    public float speed = 5f;
    private float jump_point = 0f;
    private Vector3 moveVelocity;
    public float jump_kolvo = 1f;

    private float horizontal;
    private float ostatok;
    public Joystick joystick;
    

    public GameObject blink;
    public GameObject passivka;

    public GameObject blink_z;
    public GameObject passivka_z;
    public GameObject blink_button;
    public GameObject passivka_button;

    //Перемещение

    public float jumpforse = 5f;
    public float timemax = 1f;

    public static float blink_on = 0f;
    public static float pasivka_on = 0f;

    public float MaxTimeJump = 0.41f;
    public float TimeJump;
    public bool KdJump = false;
    private bool isGrounded;
    public Transform feetPos;
    public float checkRadius;
    public LayerMask whatIsGround;

    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        isObjectDetected = false;

        animator = GetComponent<Animator>();
    }

    public void Update()
    {
        RaycastHit2D raycast = Physics2D.Raycast(rb.position, Vector2.down, LayerMask.GetMask("Ground"));



        
        //jamp
        isGrounded = Physics2D.OverlapCircle(feetPos.position, checkRadius, whatIsGround);


        if(jump_point >= 1f && jump_button.jumpknp == true && isGrounded == false)
        {
            jump_point -= 1f;
            rb.velocity = Vector2.up * jumpforse;
            animator.SetTrigger("Jump");
            jump_button.jumpknp = false;
        }

        if(isGrounded == true && jump_button.jumpknp == true)
        {
            rb.velocity = Vector2.up * jumpforse;
            animator.SetTrigger("Jump");
            jump_button.jumpknp = false;
        }
        else if(isGrounded == false && jump_button.jumpknp == true)
        {
            jump_button.jumpknp = false;
        }

        if(isGrounded == true)
        {
            jump_point = jump_kolvo;
        }



        TimeJump += 0.1f * Time.deltaTime;

        if (TimeJump > MaxTimeJump)
        {
            TimeJump = MaxTimeJump;
        }

        if (TimeJump < 0)
        {
            TimeJump = 0;
        }

        if(blink_on == 1f)
        {
            blink.SetActive(true);
            blink_button.SetActive(false);
            blink_z.SetActive(true);
        }
        if(pasivka_on == 1f)
        {
            passivka.SetActive(true);
            passivka_button.SetActive(false);
            passivka_z.SetActive(true);
        }




        //povorot
        double xpov = joystick.Horizontal;
        if (xpov < 0)
        {
            animator.SetBool("Run", true);
            transform.localRotation = Quaternion.Euler(0, 0, 0);
            
        }
        if (xpov == 0)
        {
            animator.SetBool("Run", false);
        }

        if (xpov > 0)
        {
            transform.localRotation = Quaternion.Euler(0, 180, 0);
            animator.SetBool("Run", true);
        }

        
    }
    
    private void FixedUpdate()
    {
        //dvisjenie levo pravo
        horizontal = joystick.Horizontal;
        moveVelocity = new Vector2(horizontal, 0);
        transform.position += moveVelocity * speed * Time.deltaTime;

    }

    public void Raycast(Collision2D collision)
    {
        Vector2 direction = transform.right;

        RaycastHit2D hit = Physics2D.Raycast(transform.position, direction, RaycastDistanse);

        if (collision.gameObject.tag == collisionTagGround)
        {
            Debug.Log("Object detected!");
            isObjectDetected = true;
        }
        else
        {
            isObjectDetected = false;
        }
    }

}