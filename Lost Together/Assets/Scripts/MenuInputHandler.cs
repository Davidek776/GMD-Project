using UnityEngine;

public class MenuInputHandler : MonoBehaviour
{
    public void HandleOpenCloseMenu(){
        var pauseMenu = GameObject.FindGameObjectWithTag("InGameCanvas").GetComponent<PauseMenu>();
        if (PauseMenu.isGamePaused)
        {
            pauseMenu.ResumeGame();
        }
        else
        {
            pauseMenu.PauseGame();
        }
    }
}
