using System;
using UnityEngine;
using UnityEngine.InputSystem;

public class Movement_P2 : MonoBehaviour
{
    private float speed = 8.0f;
    private float horizontalInput;
    public float jumpPower = 12.0f;
    private bool isFacingRight = true;

    public bool isGrounded = false;

    public Rigidbody2D rb;
    public LayerMask groundLayer;
    public Transform groundCheckCollider;

    Animator animator;

    void Start()
    {
        animator = GetComponent<Animator>();
    }

     void FixedUpdate(){
        GroundCheck();

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

  private void GroundCheck()
{
    isGrounded = false;
    Collider2D[] colliders = Physics2D.OverlapCircleAll(groundCheckCollider.position, 0.2f, groundLayer);
    if (colliders.Length > 0)
    {
        isGrounded = true;
        Debug.Log("Grounded");
    }
    else
    {
        isGrounded = false;
    }
}


    public void Move(InputAction.CallbackContext context)
    {
        horizontalInput = context.ReadValue<Vector2>().x;
    }

    public void Jump(InputAction.CallbackContext context)
    {
        if (context.performed && isGrounded)
        {
            rb.velocity = new Vector2(rb.velocity.x, jumpPower);
            animator.SetBool("isJumping", true);
        }
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "Ground")
        {
            animator.SetBool("isJumping", false);
        }
    }
}
