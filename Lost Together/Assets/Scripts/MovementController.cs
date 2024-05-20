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
    private bool jumpCanceled = true;

    private Rigidbody2D rb;
    public LayerMask groundLayer;
    public Transform groundCheck;

    private Animator animator;

    private Respawn respawn;
    private ControlsHint controlsHint;
    private CharacterFXPlayer characterFXPlayer;
    private int playerIndex = 0;

    void Start()
    {
        animator = GetComponent<Animator>();
        respawn = GetComponent<Respawn>();
        rb = GetComponent<Rigidbody2D>();
        controlsHint = GetComponent<ControlsHint>();
        characterFXPlayer = GetComponent<CharacterFXPlayer>();

        if (gameObject.CompareTag("Player1"))
        {
            jumpPower = 8.0f;
            playerIndex = 0;
        }
        else
        {
            jumpPower = 12.0f;
            playerIndex = 1;
        }
    }

    // Update is called once per frame
    void Update()
    {
        if (!jumpCanceled)
        {
            Jump();
        }

        if (respawn.canMove)
        {
            if (horizontalInput != 0 && isGrounded())
                characterFXPlayer.PlayRunningSound(transform, GetPlayerIndex());

            rb.velocity = new Vector2(horizontalInput * speed, rb.velocity.y);
        }
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

        if (!controlsHint.hintDisabled && input != 0)
            controlsHint.DisableHint();
    }

    public float GetHorizontalInput()
    {
        return horizontalInput;
    }

    public void Jump()
    {
        jumpCanceled = false;
        if (respawn.canMove && isGrounded())
        {
            rb.velocity = new Vector2(rb.velocity.x, jumpPower);
            animator.SetBool("isJumping", true);
            characterFXPlayer.PlayJumpSound(transform, GetPlayerIndex());
        }
    }

    public void StopJump()
    {
        jumpCanceled = true;
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

    public bool IsFacingRight()
    {
        return isFacingRight;
    }
}
