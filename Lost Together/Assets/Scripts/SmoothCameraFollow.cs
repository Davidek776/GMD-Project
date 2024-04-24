using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SmoothCameraFollow : MonoBehaviour
{
    private Vector3 velocity = Vector3.zero;
    private MovementController movementController;
    private Vector3 targetOffset;
    private Vector3 currentOffset;

    public GameObject target;
    public float smoothSpeed = 0.25f;
    public float directOffsetX = 0f;  
    public float aheadOffsetX = 5f; 
    public float sideOffsetX = 5f;
    public float offsetChangeSpeed = 5f;

    void Start()
    {
        movementController = target.GetComponent<MovementController>();
        currentOffset = targetOffset = CalculateOffset();
    }

    void Update()
    {
        float horizontalInput = movementController.GetHorizontalInput();

        if (horizontalInput == 0)
        {
            targetOffset = new Vector3(directOffsetX, 2f, -10);
        }
        else if (horizontalInput > 0)
        {
            targetOffset = new Vector3(aheadOffsetX, 2f, -10);
        }
        else
        {
            targetOffset = new Vector3(-aheadOffsetX, 2f, -10);
        }

        currentOffset = Vector3.Lerp(currentOffset, targetOffset, smoothSpeed * Time.deltaTime * offsetChangeSpeed);

        Vector3 targetPosition = target.transform.position + currentOffset;
        Vector3 smoothedPosition = Vector3.SmoothDamp(transform.position, targetPosition, ref velocity, smoothSpeed);

        transform.position = smoothedPosition;
    }

    Vector3 CalculateOffset()
    {
        float horizontalInput = movementController.GetHorizontalInput();

        if (horizontalInput == 0)
        {
            return new Vector3(directOffsetX, 2f, -10);
        }
        else if (horizontalInput > 0)
        {
            return new Vector3(aheadOffsetX, 2f, -10);
        }
        else
        {
            return new Vector3(-aheadOffsetX, 2f, -10);
        }
    }
}
