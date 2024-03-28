using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SmoothCameraFollow : MonoBehaviour
{
    private Vector3 offset = new Vector3(0, 2f, -10);
    private Vector3 velocity = Vector3.zero;

    public Transform target;
    public float smoothSpeed = 0.25f;

    // Update is called once per frame
    void Update()
    {
        Vector3 targetPosition = target.position + offset;
        Vector3 smoothedPosition = Vector3.SmoothDamp(transform.position, targetPosition, ref velocity, smoothSpeed);

        transform.position = smoothedPosition;
    }
}
