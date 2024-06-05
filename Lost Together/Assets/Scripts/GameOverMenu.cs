using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.SceneManagement;

public class GameOverMenu : MonoBehaviour
{
    public GameObject gameOverFirstButton;

    public bool isActive;
     void Start()
    {
        isActive = false;
        gameObject.SetActive(false);        
    }

    public void Show()
    {
        gameObject.SetActive(true);
        EventSystem.current.SetSelectedGameObject(null);
        EventSystem.current.SetSelectedGameObject(gameOverFirstButton); 
        Time.timeScale = 0f;
        isActive=true;
    }

     public void RestartGame()
    {
        SceneLoader.instance.LoadScene(SceneManager.GetActiveScene().buildIndex);
        Time.timeScale = 1f;
        }

     public void LoadMenu()
    {
        SceneLoader.instance.LoadScene("Menu");
        Time.timeScale = 1f;
    }

    public void NextLevel()
    {
        int mexScene = SceneManager.sceneCountInBuildSettings;
        if (SceneManager.GetActiveScene().buildIndex + 1 < mexScene)
        {
            SceneLoader.instance.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
        }
        else
        {
            SceneLoader.instance.LoadScene("Menu");
        }

        Time.timeScale = 1f;
    }
}
