using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TriggerButton : MonoBehaviour
{
    public float buttonPressedOffset = 0.4f;
    public GameObject playerCollider;

    [SerializeField] private ISwitchable client;

    private Vector3 buttonPressedPosition;
    private Vector3 initialButtonPosition;
    private bool isPressed = false;
    private bool isDelayFinished = false;

    void Start()
    {
        initialButtonPosition = transform.position;
        buttonPressedPosition = initialButtonPosition - new Vector3(0f, buttonPressedOffset, 0f);
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if ((collision.gameObject == playerCollider) && !isPressed)
        {
            StartCoroutine(MoveButtonDownWithDelay());
            isPressed = true;
        }
    }

    private void OnCollisionExit2D(Collision2D collision)
    {
        if (collision.gameObject == playerCollider)
        {
            isPressed = false;
            if (isDelayFinished == true)
            {
                MoveButtonUp();
            }
        }
    }

    private IEnumerator MoveButtonDownWithDelay()
    {
        transform.position = buttonPressedPosition;

        if (client != null)
        {
            client.Activate();
        }


        isDelayFinished = false;

        yield return new WaitForSeconds(0.2f);

        isDelayFinished = true;

        if (!isPressed)
        {
            MoveButtonUp();
        }
    }

    private void MoveButtonUp()
    {
        transform.position = initialButtonPosition;
        if (client != null)
        {
            client.Deactivate();

        }
    }
}
