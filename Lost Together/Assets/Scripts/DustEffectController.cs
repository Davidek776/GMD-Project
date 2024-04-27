using System;
using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class DustEffectController : MonoBehaviour
{
    [SerializeField] private ParticleSystem dustEffectMovement;
    [SerializeField] private ParticleSystem dustEffectFalling;
    [SerializeField] private Rigidbody2D rb;
    private int occurAfterVelocity = 1;
    private float dustFormationPeriod = 0.06f;
    private float counter;
    private bool isOnGround;

    // Update is called once per frame
    void Update()
    {
        counter += Time.deltaTime;

        if (isOnGround && Mathf.Abs(rb.velocity.x) > occurAfterVelocity)
        {
            if (counter > dustFormationPeriod)
            {
                dustEffectMovement.Play();
                counter = 0;
            }
        }
    }

    private void OnTriggerEnter2D(Collider2D collider)
    {
        if (collider.CompareTag("Ground"))
        {
            isOnGround = true;
            Debug.Log("On Ground");
            dustEffectFalling.Play();
        }
    }

    private void OnTriggerExit2D(Collider2D collider)
    {
        if (collider.CompareTag("Ground"))
        {
            isOnGround = false;
        }
    }

}
