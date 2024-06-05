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
    private GameObject levelOneButton, levelTwoButton, levelThreeButton, playButton;
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

    public void CloseLevelMenu()
    {
        levelMenu.SetActive(false);
        EventSystem.current.SetSelectedGameObject(null);
        EventSystem.current.SetSelectedGameObject(playButton);
    }

    public void PlayLevelOne()
    {
        PlayLevel(1);
    }

    public void PlayLevelTwo()
    {
        PlayLevel(2);
    }

    public void PlayLevelThree()
    {
        PlayLevel(3);
    }

    public void PlayLevel(int index)
    {
        SceneLoader.instance.LoadScene(index);
    }

}
