using System.Collections;
using UnityEngine;

public class HorizontalMovement : ISwitchable
{
    private bool isActive;
    private Coroutine movementCoroutine;

    public float horizontalOffset = 1f;
    public float movementSpeed = 1f;

    private Vector3 originalPosition;

    public override bool IsActive => isActive;
    private int activationCount = 0;

    private void Start()
    {
        originalPosition = transform.position;
    }

    public override void Activate()
    {
        isActive = true;
        activationCount++;
        if (movementCoroutine != null)
        {
            StopCoroutine(movementCoroutine);
        }
        movementCoroutine = StartCoroutine(MoveOverTime(originalPosition + new Vector3(horizontalOffset, 0f, 0f)));
    }

    public override void Deactivate()
    {
        activationCount--;
        if (activationCount == 0)
        {
            isActive = false;
            if (movementCoroutine != null)
            {
                StopCoroutine(movementCoroutine);
            }
            movementCoroutine = StartCoroutine(MoveOverTime(originalPosition));
        }
    }

    private IEnumerator MoveOverTime(Vector3 targetPosition)
    {
        float elapsedTime = 0f;
        Vector3 initialPosition = transform.position;
        float duration = Vector3.Distance(initialPosition, targetPosition) / movementSpeed;
        while (elapsedTime < duration)
        {
            elapsedTime += Time.deltaTime;
            float t = Mathf.Clamp01(elapsedTime / duration);
            transform.position = Vector3.Lerp(initialPosition, targetPosition, t);
            yield return null;
        }

        transform.position = targetPosition;
    }
}
