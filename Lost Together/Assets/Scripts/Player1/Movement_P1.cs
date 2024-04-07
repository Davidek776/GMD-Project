using System;
using UnityEngine;
using UnityEngine.InputSystem;

public class Movement_P1 : MonoBehaviour
{
    private float speed = 8.0f;
    private float horizontalInput;
    public float jumpPower = 8.0f;
    private bool isFacingRight = true;

    public Rigidbody2D rb;
    public LayerMask groundLayer;
    public Transform groundCheck;

    Animator animator;

    void Start(){
        animator = GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
        rb.velocity = new Vector2(horizontalInput * speed, rb.velocity.y);
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

    public void Move(InputAction.CallbackContext context)
    {
        horizontalInput = context.ReadValue<Vector2>().x;
    }

    public void Jump(InputAction.CallbackContext context)
    {
        if (context.performed && isGrounded())
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
}