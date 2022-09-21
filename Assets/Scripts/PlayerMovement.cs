using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    
    public float speed = 5.5f;

    private float horizontal;

    private Transform playerTransform;
    private Rigidbody2D rb;
    void Awake()
    {

        playerTransform = GetComponent<Transform>();
        rb = GetComponent<Rigidbody2D>();

    }

    //cock and balls
    void FixedUpdate()
    {
        horizontal = Input.GetAxis("Horizontal");
        //El GetAxis hace que el movimiento sea un poco Smooth, para quitarlo deberiamos hacer GetAxisRaw, entonces es mas seco
        //playerTransform.position += new Vector3(horizontal * speed * Time.deltaTime, 0, 0);

        //playerTransform.Translate(Vector3.right * horizontal * speed * Time.deltaTime, Space.World);
        rb.velocity = new Vector2 (horizontal * speed, 0);
    }
}
