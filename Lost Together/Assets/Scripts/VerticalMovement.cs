using System.Collections;
using UnityEngine;

public class VerticalMovement : ISwitchable
{
    private bool isActive;
    private Coroutine movementCoroutine;

    public float verticalOffset = 1f;

    private Vector3 originalPosition;

    private int activationCount = 0;

    private void Start()
    {
        originalPosition = transform.position;
    }

    public override bool IsActive => isActive;

    public override void Activate()
    {
        isActive = true;
        activationCount++;
        if (movementCoroutine != null)
        {
            StopCoroutine(movementCoroutine);
        }
        movementCoroutine = StartCoroutine(MoveOverTime(originalPosition + new Vector3(0f, verticalOffset, 0f)));

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
        float duration = 1f;

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
