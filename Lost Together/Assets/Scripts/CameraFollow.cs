using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraFollow : MonoBehaviour
{
    private Vector3 offset = new Vector3(0f, 0f, 0f);
    private float smoothTime = 0.25f;
    private Vector3 velocity = Vector3.zero;

    public Transform target;

    // Update is called once per frame
    void Update()
    {
        // Smoothly move the camera towards that target position but excluding the y-axis
        Vector3 targetPosition = new Vector3(target.position.x, transform.position.y, transform.position.z);
        transform.position = Vector3.SmoothDamp(transform.position, targetPosition, ref velocity, smoothTime);
    }
}
