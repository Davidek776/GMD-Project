using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyPatrol : MonoBehaviour
{
    public Transform pointA;
    public Transform pointB;
    public float speed = 2f;
    public float chaseRange = 5f;
    private Rigidbody2D rb;
    private Animator anim;
    private Transform currentPoint;
    private GameObject[] players;

    private void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        anim = GetComponent<Animator>();
        currentPoint = pointB; 
        anim.SetBool("isRunning", true);
    }

   private void Update()
{
    GameObject[] players = GameObject.FindGameObjectsWithTag("Player1");
    GameObject[] players2 = GameObject.FindGameObjectsWithTag("Player2");
    List<GameObject> allPlayers = new List<GameObject>(players);
    allPlayers.AddRange(players2);

    GameObject closestPlayer = FindClosestPlayer(allPlayers);

    if (closestPlayer != null)
    {
        float distanceToPlayer = Vector2.Distance(transform.position, closestPlayer.transform.position);

        if (distanceToPlayer < chaseRange && IsPlayerInPatrolBounds(closestPlayer))
        {
            ChasePlayer(closestPlayer);
            return; 
        }
    }
    Patrol();
}

private GameObject FindClosestPlayer(List<GameObject> players)
{
    float closestDistance = Mathf.Infinity;
    GameObject closestPlayer = null;

    foreach (GameObject player in players)
    {
        float distance = Vector2.Distance(transform.position, player.transform.position);
        if (distance < closestDistance)
        {
            closestDistance = distance;
            closestPlayer = player;
        }
    }

    return closestPlayer;
}

   private void Patrol()
{
    Vector2 targetPoint = new Vector2(currentPoint.position.x, transform.position.y);
    Vector2 moveDirection = (targetPoint - (Vector2)transform.position).normalized;
    rb.velocity = new Vector2(moveDirection.x * speed, 0);
    if (moveDirection.x > 0)
    {
        transform.localScale = new Vector3(Mathf.Abs(transform.localScale.x), transform.localScale.y, transform.localScale.z);
    }
    else if (moveDirection.x < 0)
    {
        transform.localScale = new Vector3(-Mathf.Abs(transform.localScale.x), transform.localScale.y, transform.localScale.z);
    }
    if (Vector2.Distance(transform.position, targetPoint) < 0.1f)
    {
        SwitchPatrolPoint();
    }
}


    private void ChasePlayer(GameObject player)
    {
        Vector2 direction = (player.transform.position - transform.position).normalized;
        rb.velocity = new Vector2(direction.x * speed, rb.velocity.y);

        if (player.transform.position.x > transform.position.x)
        {
            transform.localScale = new Vector3(Mathf.Abs(transform.localScale.x), transform.localScale.y, transform.localScale.z);
        }
        else
        {
            transform.localScale = new Vector3(-Mathf.Abs(transform.localScale.x), transform.localScale.y, transform.localScale.z);
        }
    }

    private void SwitchPatrolPoint()
    {
        currentPoint = (currentPoint == pointA) ? pointB : pointA;
    }

    private bool IsPlayerInPatrolBounds(GameObject player)
    {
        return player.transform.position.x >= Mathf.Min(pointA.position.x, pointB.position.x)
            && player.transform.position.x <= Mathf.Max(pointA.position.x, pointB.position.x);
    }

      private void OnDrawGizmos(){
        Gizmos.DrawWireSphere(pointA.transform.position, 0.5f);
        Gizmos.DrawWireSphere(pointA.transform.position, 0.5f);
        Gizmos.DrawLine(pointA.transform.position, pointB.transform.position);
    }

}
