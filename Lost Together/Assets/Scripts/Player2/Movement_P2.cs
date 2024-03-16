using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class Movement_P2 : MonoBehaviour
{
    private float speed = 8.0f;
    private float horizontalInput;
    private float jumpPower = 16.0f;
    private bool isFacingRight = true;

    public Rigidbody2D rb;
    public LayerMask groundLayer;
    public Transform groundCheck;

    // Update is called once per frame
    void Update()
    {
        rb.velocity = new Vector2(horizontalInput * speed, rb.velocity.y);

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
        return Physics2D.OverlapCircle(groundCheck.position, 0.2f, groundLayer);
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
        }

        if (context.canceled && rb.velocity.y > 0f)
        {
            rb.velocity = new Vector2(rb.velocity.x, rb.velocity.y * speed * Time.deltaTime);
        }
    }
}
