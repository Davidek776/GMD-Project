using System.Collections;
using UnityEngine;

public class Respawn : MonoBehaviour
{

    private Vector2 startPos;
    private Animator animator;
    public bool canMove = true;

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
            animator.SetBool("isDead", true);
            Die(0.5f);
        }
    }

    private void Die(float respawnDuration)
    {
        canMove = false;
        StartCoroutine(RespawnPlayer(respawnDuration));
    }

    private IEnumerator RespawnPlayer(float duration = 0)
    {
        yield return new WaitForSeconds(duration);
        animator.SetBool("isDead", false);
        transform.position = startPos;
        canMove = true;
    }
}
