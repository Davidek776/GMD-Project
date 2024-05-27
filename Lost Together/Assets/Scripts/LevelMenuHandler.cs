using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;
using UnityEngine.SceneManagement;


public class LevelMenuHandler : MonoBehaviour
{
    public static LevelMenuHandler instance;

    [SerializeField]
    private GameObject levelMenu
;
    [SerializeField]
    private GameObject levelOneButton, levelTwoButton, levelThreeButton;
    [SerializeField]
    private void Awake()
    {
        if (instance == null)
        {
            instance = this;
        }
    }

    // Start is called before the first frame update
    void Start()
    {
        levelMenu.SetActive(false);
    }

    public void OpenLevelMenu()
    {
        levelMenu.SetActive(true);

        EventSystem.current.SetSelectedGameObject(null);
        EventSystem.current.SetSelectedGameObject(levelOneButton);
    }
    public void PlayLevelOne()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
    }

     public void PlayLevelTwo()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 2);
    }

}
