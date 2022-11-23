using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Repas_Player : MonoBehaviour
{
    [SerializeField]float speed;
    [SerializeField]float jumpForce;
    private Rigidbody2D rBody;
    private Transform playerTransform;
    float horizontal;

    [SerializeField]bool isGrounded;
    [SerializeField]Transform groundSensor;
    [SerializeField]float sensorRadius;
    [SerializeField]LayerMask ground;

    Animator anim;

    
    private void Awake() 
    {
        rBody = GetComponent<Rigidbody2D>();
        playerTransform = GetComponent<Transform>(); 
        anim = GetComponentInChildren<Animator>();   
    }
    void Start()
    {
        
    }

    /*void Movimiento()
    {
        float horizontal = Input.GetAxisRaw("Horizontal");
        playerTransform.position += new Vector3(horizontal * speed * Time.deltaTime, 0f, 0f);

    }*/
    void Update()
    {
        //Movimiento();
        horizontal = Input.GetAxisRaw("Horizontal");
        Jump();
    }

    private void FixedUpdate() 
    {
        rBody.velocity = new Vector2(horizontal * speed, rBody.velocity.y); 
        if(horizontal < 0)
        {
            playerTransform.rotation = Quaternion.Euler(0, 180, 0);
            anim.SetBool("Caminar", true);
            
        }
        else if(horizontal > 0)
        {
            playerTransform.rotation = Quaternion.Euler(0, 0, 0);
            anim.SetBool("Caminar", true);
        }
        else if(horizontal == 0)
        {
            anim.SetBool("Caminar", false);
        }

               
    }

    void Jump()
    {
        isGrounded = Physics2D.OverlapCircle(groundSensor.position, sensorRadius, ground);
        if(Input.GetButtonDown("Jump") && isGrounded)
        {
            rBody.AddForce(transform.up * jumpForce, ForceMode2D.Impulse);
            anim.SetBool("Jump", true);
        }
        else
        {
            anim.SetBool("Jump", false);
        }
        
    }

    private void OnDrawGizmos() 
    {
        Gizmos.color = Color.red;
        Gizmos.DrawWireSphere(groundSensor.position, sensorRadius);   
    }
}
