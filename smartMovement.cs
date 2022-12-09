using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class smartMovement : MonoBehaviour
{
   //2d movement with rigidbody2d and jump
    public float speed = 5f;
    public Rigidbody2D rb;
    Vector2 movement;
    public float jumpForce = 5f;
    public Transform groundCheck;
    
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }
    
    void Update()
    {
        movement.x = Input.GetAxisRaw("Horizontal");
        movement.y = Input.GetAxisRaw("Vertical");

        if (Input.GetButtonDown("Jump"))
        {
            rb.AddForce(Vector2.up * jumpForce, ForceMode2D.Impulse);
        }
    }

    void FixedUpdate()
    {
        rb.MovePosition(rb.position + movement * speed * Time.fixedDeltaTime);
    }
}
