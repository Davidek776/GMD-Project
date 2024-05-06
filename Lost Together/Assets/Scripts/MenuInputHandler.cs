using UnityEngine;
using UnityEngine.InputSystem;

public class MenuInputHandler : MonoBehaviour
{
    public void HandleOpenCloseMenu(InputAction.CallbackContext context)
    {
        if (context.performed)
        {
            if (PauseMenu.instance.isGamePaused)
            {
                OptionsMenuHandler.instance.CloseOptionsMenu();
                PauseMenu.instance.ResumeGame();
            }
            else
            {
                PauseMenu.instance.PauseGame();
            }
        }
    }
}
