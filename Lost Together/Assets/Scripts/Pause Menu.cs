using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.SceneManagement;

public class PauseMenu : MonoBehaviour
{
    public static PauseMenu instance;
    public bool isGamePaused = false;

    [SerializeField]
    private GameObject pauseMenu;
    [SerializeField]
    private GameObject mainFirstButton;
    [SerializeField]
    private GameObject player1;
    [SerializeField]
    private GameObject player2;

    [SerializeField]
    private GameOverMenu gameOverMenu;

    [SerializeField]
    private HelpText helpTextOne;

    [SerializeField]
    private HelpText helpTextTwo;

    private void Awake()
    {
        if (instance == null)
        {
            instance = this;
        }
    }

    void Start()
    {
        pauseMenu.SetActive(false);
    }

    public void ResumeGame()
    {
        if(pauseMenu.activeSelf == true)
            HidePauseMenu();
            
        Time.timeScale = 1f;
        isGamePaused = false;

        player1.GetComponent<MovementController>().enabled = true;
        player2.GetComponent<MovementController>().enabled = true;
    }

    public void PauseGame()
    {
        if (gameOverMenu.isActive == false)
        {
            if (helpTextOne.isActive == true || helpTextTwo.isActive == true)
            {
                helpTextOne.Hide();
                helpTextTwo.Hide();
            }

            LoadPauseMenu();

            Time.timeScale = 0f;
            isGamePaused = true;
            player1.GetComponent<MovementController>().enabled = false;
            player2.GetComponent<MovementController>().enabled = false;
        }
    }

    public void PauseGameWithoutMenu()
    {
        Time.timeScale = 0f;
        isGamePaused = true;
        player1.GetComponent<MovementController>().enabled = false;
        player2.GetComponent<MovementController>().enabled = false;
    }

    public void HidePauseMenu()
    {
        pauseMenu.SetActive(false);
    }

    public void LoadPauseMenu()
    {
        pauseMenu.SetActive(true);
        EventSystem.current.SetSelectedGameObject(null);
        EventSystem.current.SetSelectedGameObject(mainFirstButton);
    }

    public void LoadMenu()
    {
        SceneManager.LoadScene("Menu");
        Time.timeScale = 1f;
    }
}
