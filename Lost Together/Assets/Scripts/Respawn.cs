using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Respawn : MonoBehaviour
{

    private Vector2 startPos;
    private Animator animator;

    // Start is called before the first frame update
    void Start()
    {
        startPos = transform.position;
        animator = GetComponent<Animator>();
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("DeadZone"))
        {
            Die(0f);
        }
        else if (collision.CompareTag("Spike"))
        {
            Die(0.5f);
        }
    }

    private void Die(float respawnDuration)
    {
        animator.SetBool("isDead", true);
        Debug.Log("Is dead: " + animator.GetBool("isDead"));
        StartCoroutine(RespawnPlayer(respawnDuration));
    }

    IEnumerator RespawnPlayer(float duration = 0)
    {
        yield return new WaitForSeconds(duration);
        animator.SetBool("isDead", false);
        Debug.Log("Is dead: " + animator.GetBool("isDead"));
        transform.position = startPos;
    }
}
