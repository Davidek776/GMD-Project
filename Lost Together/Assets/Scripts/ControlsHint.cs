using UnityEngine;
using System.Collections;
using UnityEngine.InputSystem;

public class ControlsHint : MonoBehaviour
{
    public GameObject controlsHint;
    private float horizontalInput;

    // Start is called before the first frame update
    void Start()
    {
        controlsHint.SetActive(true);
    }

    // Update is called once per frame
    void Update()
    {
        if (horizontalInput != 0 && controlsHint.activeSelf)
        {
            controlsHint.SetActive(false);
            Debug.Log("Controls hint disabled");
        }
    }

    public void DisableHint(InputAction.CallbackContext context)
    {
        horizontalInput = context.ReadValue<Vector2>().x;
    }
}
