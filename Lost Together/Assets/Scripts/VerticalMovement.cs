using System.Collections;
using UnityEngine;

public class VerticalMovement : ISwitchable
{
    private bool isActive;
    private Coroutine activationCoroutine;
    private Coroutine deactivationCoroutine;

    public float verticalOffset = 0.3f;

    public override bool IsActive => isActive;

    public override void Activate()
    {
        if (deactivationCoroutine != null)
            StopCoroutine(deactivationCoroutine);

        isActive = true;
        activationCoroutine = StartCoroutine(ChangeScaleOverTime(Vector3.Scale(transform.localScale, new Vector3(1f, verticalOffset, 1f))));
    }

    public override void Deactivate()
    {
        if (activationCoroutine != null)
            StopCoroutine(activationCoroutine);

        deactivationCoroutine = StartCoroutine(ChangeScaleOverTime(Vector3.one));
    }

    private IEnumerator ChangeScaleOverTime(Vector3 targetScale)
    {
        float elapsedTime = 0f;
        Vector3 initialScale = transform.localScale;
        float duration = 1f;

        while (elapsedTime < duration)
        {
            elapsedTime += Time.deltaTime;
            float t = Mathf.Clamp01(elapsedTime / duration);
            transform.localScale = Vector3.Lerp(initialScale, targetScale, t);
            yield return null;
        }

        transform.localScale = targetScale;

        if (targetScale == Vector3.one)
            isActive = false;
    }
}
