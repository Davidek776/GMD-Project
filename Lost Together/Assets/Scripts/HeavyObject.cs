using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HeavyObject : MonoBehaviour
{
    private Rigidbody2D rb;
    private bool isColliding = false;

    private void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        HandleCollision(collision);
    }

    private void OnCollisionStay2D(Collision2D collision)
    {
        HandleCollision(collision);
    }

    private void OnCollisionExit2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag("Player1") || collision.gameObject.CompareTag("Player2"))
    {
        rb.bodyType = RigidbodyType2D.Static;
        isColliding=false;
    }

    if (collision.gameObject.CompareTag("Ground") || collision.gameObject.CompareTag("Box"))
    {
        rb.bodyType = RigidbodyType2D.Dynamic;
        isColliding=false;
    }
    
     if (isColliding==false)
        {
            rb.bodyType = RigidbodyType2D.Dynamic;
        }
    }

    private void HandleCollision(Collision2D collision)
    {
        if (collision.gameObject.CompareTag("Player2"))
        {
            rb.bodyType = RigidbodyType2D.Static;
            isColliding=true;
        }
        if (collision.gameObject.CompareTag("Player1"))
        {
            rb.bodyType = RigidbodyType2D.Dynamic;
            isColliding=true;
        }

    }
}
