using System.Collections;
using System.Collections.Generic;
using System.Linq;
using UnityEngine;
using UnityEngine.InputSystem;

public class PlayerInputHandler : MonoBehaviour
{
    private PlayerInput playerInput;
    private MovementController movementController;
    // Start is called before the first frame update
    void Start()
    {
        playerInput = GetComponent<PlayerInput>();
        var movers = FindObjectsOfType<MovementController>();
        var index = playerInput.playerIndex;
        movementController = movers.FirstOrDefault(m => m.playerIndex == index);
    }

    // Update is called once per frame
    public void Move(InputAction.CallbackContext context)
    {
        var horizontalInput = context.ReadValue<Vector2>().x;
        if(movementController != null && movementController.isActiveAndEnabled)
            movementController.SetHorizontalInput(horizontalInput);
    }

    public void Jump(InputAction.CallbackContext context)
    {
        if (context.performed && movementController != null && movementController.isActiveAndEnabled)
        {
            movementController.Jump();
        }
        if(context.canceled && movementController != null && movementController.isActiveAndEnabled){
            movementController.StopJump();
        }
    }
}
