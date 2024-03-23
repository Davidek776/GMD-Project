using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TriggerButton : MonoBehaviour
{
    public float buttonPressedOffset = 0.1f;
    private Vector3 buttonPressedPosition;
     private Vector3 initialButtonPosition;

      private bool isPressed = false;
    // Start is called before the first frame update
    void Start()
    {
        initialButtonPosition = transform.position;
        buttonPressedPosition = initialButtonPosition - new Vector3(0f, buttonPressedOffset, 0f);
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if ((collision.gameObject.CompareTag("Player1")) && !isPressed)
        {
            MoveButtonDown();
            isPressed = true;
        }
    }

     private void OnCollisionExit2D(Collision2D collision)
    {
        if ((collision.gameObject.CompareTag("Player1"))&& isPressed)
        {
            MoveButtonUp();
            isPressed = false;
            Debug.Log("Up");
        }
    }

     private void MoveButtonDown()
    {
        // transform.Translate(buttonPressedPosition*Time.deltaTime*1f);
        transform.position=buttonPressedPosition;

    }
    private void MoveButtonUp()
    {
        // Vector3 newVector=initialButtonPosition-transform.position;
        // transform.Translate(newVector*Time.deltaTime*10f);
        transform.position=initialButtonPosition;

    }
}
