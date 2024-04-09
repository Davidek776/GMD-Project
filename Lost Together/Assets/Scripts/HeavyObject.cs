using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HeavyObject : MonoBehaviour
{
    private Rigidbody2D rb;
    private HashSet<Collider2D> collidersInContact = new HashSet<Collider2D>();

    private void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag("Player2") )
        {
             rb.bodyType = RigidbodyType2D.Static;
        }

        if (collision.gameObject.CompareTag("Player1") )
        {
             rb.bodyType = RigidbodyType2D.Dynamic;
        }
        // else{
        //      rb.bodyType = RigidbodyType2D.Dynamic;

        // }
    }

    private void OnCollisionStay2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag("Player2"))
        {
            rb.bodyType = RigidbodyType2D.Static;
        }
         if (collision.gameObject.CompareTag("Player1") )
        {
             rb.bodyType = RigidbodyType2D.Dynamic;
        }
        // else{
        //      rb.bodyType = RigidbodyType2D.Dynamic;
        // }
    }

  private void OnCollisionExit2D(Collision2D collision)
{
    if (collision.gameObject.CompareTag("Player1") || collision.gameObject.CompareTag("Player2"))
    {
        rb.bodyType = RigidbodyType2D.Static;
        Debug.Log("HERE");

    }
    else
    {
        Debug.Log("Other object exited collision: " + collision.gameObject.name);
    }
}

}
