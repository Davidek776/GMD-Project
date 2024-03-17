using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TriggerButton : MonoBehaviour
{
    public float buttonPressedOffset = 0.1f;
    private Vector3 buttonPressedPosition;
     private Vector3 initialButtonPosition;
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
        if (collision.gameObject.CompareTag("Player1"))
        {
            MoveButtonDown();
        }
    }

     private void OnCollisionExit2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag("Player1"))
        {
            MoveButtonUp();
        }
    }

     private void MoveButtonDown()
    {
        transform.position = buttonPressedPosition;
    }
    private void MoveButtonUp()
    {
        transform.position = initialButtonPosition;
    }
}
