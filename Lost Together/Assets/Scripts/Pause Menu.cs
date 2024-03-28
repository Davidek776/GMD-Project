using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PauseMenu : MonoBehaviour
{
    public static bool isGamePaused = false;

    [SerializeField]
    private GameObject pauseMenu;

    void Start(){
        pauseMenu.SetActive(false);
    }
    // Update is called once per frame
    void Update()
    {
        if(Input.GetKeyDown(KeyCode.Escape)){
            if(isGamePaused){
                ResumeGame();
            }
            else{
                PauseGame();
            }
        }
    }
    public void ResumeGame(){
        pauseMenu.SetActive(false);
        Time.timeScale = 1f;
        isGamePaused = false;
    }

     void PauseGame(){
        pauseMenu.SetActive(true);
        Time.timeScale = 0f;
        isGamePaused = true;
    }

    public void LoadMenu(){
        SceneManager.LoadScene("Menu");
        Time.timeScale = 1f;
    }

    public void QuitGame(){
        Application.Quit();
    }
}
