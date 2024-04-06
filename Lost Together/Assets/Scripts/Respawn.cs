using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Respawn : MonoBehaviour
{

    private Vector2 startPos;

    // Start is called before the first frame update
    void Start()
    {
        startPos = transform.position;
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("DeadZone"))
        {
            Die();
        }
    }

    private void Die()
    {
        RespawnPlayer();
    }

    private void RespawnPlayer()
    {
        transform.position = startPos;
    }
}
