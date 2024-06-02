using System.Collections;
using UnityEngine;

public class Respawn : MonoBehaviour
{

    private Vector2 startPos;
    private Animator animator;
    private CharacterFXPlayer characterFXPlayer;
    private MovementController movementController;
    public bool canMove = true;

    // Start is called before the first frame update
    void Start()
    {
        startPos = transform.position;
        animator = GetComponent<Animator>();
        characterFXPlayer = GetComponent<CharacterFXPlayer>();
        movementController = GetComponent<MovementController>();
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("Checkpoint")){
            UpdateStartPos(transform.position);
        }

        if (collision.CompareTag("DeadZone"))
        {
            Die(0f);
        }

        else if (collision.CompareTag("Spike") || collision.CompareTag("Enemy"))
        {
            animator.SetBool("isDead", true);
            Die(0.5f);
            characterFXPlayer.PlayDeathSound(transform, movementController.GetPlayerIndex());
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

    public void UpdateStartPos(Vector2 newStartPos)
    {
        startPos = newStartPos;
    }
}
