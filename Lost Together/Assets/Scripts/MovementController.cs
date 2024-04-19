using System;
using TMPro;
using UnityEngine;
using UnityEngine.InputSystem;

public class MovementController : MonoBehaviour
{
    private float speed = 8.0f;
    private float horizontalInput;
    private float jumpPower;
    private bool isFacingRight = true;

    private Rigidbody2D rb;
    public LayerMask groundLayer;
    public Transform groundCheck;

    private Animator animator;
    
    private Respawn respawn;
    public int playerIndex = 0;

    void Start(){
        animator = GetComponent<Animator>();
        respawn = GetComponent<Respawn>();
        rb = GetComponent<Rigidbody2D>();

        if (gameObject.CompareTag("Player1"))
            jumpPower = 8.0f;
        else
            jumpPower = 12.0f;
    }

    // Update is called once per frame
    void Update()
    {
        if(respawn.canMove)
            rb.velocity = new Vector2(horizontalInput * speed, rb.velocity.y);
        else
            rb.velocity = new Vector2(0, rb.velocity.y);

        animator.SetFloat("xVelocity", Math.Abs(rb.velocity.x));
        animator.SetFloat("yVelocity", rb.velocity.y);

        Flip();
    }

    private void Flip()
    {
        if (!isFacingRight && horizontalInput > 0f || isFacingRight && horizontalInput < 0f)
        {
            isFacingRight = !isFacingRight;
            Vector3 localScale = transform.localScale;
            localScale.x *= -1f;
            transform.localScale = localScale;
        }
    }

    private bool isGrounded()
    {
        return Physics2D.OverlapBox(groundCheck.position, new Vector2(0.5f, 0.1f), 0f, groundLayer);
    }

    public void SetHorizontalInput(float input)
    {
        horizontalInput = input;
    }

    public void Jump()
    {
        if (respawn.canMove && isGrounded())
        {
            rb.velocity = new Vector2(rb.velocity.x, jumpPower);
            animator.SetBool("isJumping", true);
        }
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.layer == 6)
        {
            animator.SetBool("isJumping", false);
        }
    }

    public int GetPlayerIndex()
    {
        return playerIndex;
    } 
}
