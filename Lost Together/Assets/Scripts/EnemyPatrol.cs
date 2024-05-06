using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyPatrol : MonoBehaviour
{
    public GameObject pointA;
    public GameObject pointB;

    private RigidBody2D rb;
    private Animator anim;
    private Transform currentPoint;

    void Start()
    {
    rb=GetComponent<RigidBody2D>();
    anim=GetComponent<Animator>();
    currentPoint=pointB.transform;
    anim.SetBool("isRunning", true);
    }

    void Update()
    {
        Vector2 point=currentPoint.position-transform.position;
    }
}
