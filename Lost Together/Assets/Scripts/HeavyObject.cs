using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HeavyObject : MonoBehaviour
{
    private Rigidbody2D rb;
    public LayerMask groundLayer;

    private void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    private void Update()
    {
        if (rb.bodyType == RigidbodyType2D.Dynamic)
            rb.velocity = new Vector2(0, 0);
    }

    private void OnCollisionStay2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "Player1")
        {
            rb.bodyType = RigidbodyType2D.Dynamic;
        }
        else if (collision.gameObject.tag != "Ground")
        {
            rb.bodyType = RigidbodyType2D.Static;
        }
    }

    private void OnCollisionExit2D(Collision2D collision)
    {
        if (collision.gameObject.tag != "Ground")
        {
            rb.bodyType = RigidbodyType2D.Static;
        }
    }
}
