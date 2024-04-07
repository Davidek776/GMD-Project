using System.Collections;
using UnityEngine;

public class HorizontalMovement : ISwitchable
{
    private bool isActive;
    private Coroutine movementCoroutine;

    public float horizontalOffset = 1f; 

    private Vector3 originalPosition;

    public override bool IsActive => isActive;

    private void Start()
    {
        originalPosition = transform.position;
    }

    public override void Activate()
    {
        if (!isActive)
        {
            isActive = true;
            movementCoroutine = StartCoroutine(MoveOverTime(originalPosition + new Vector3(horizontalOffset, 0f, 0f)));
        }
    }

    public override void Deactivate()
    {
        if (isActive)
        {
            isActive = false;
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
