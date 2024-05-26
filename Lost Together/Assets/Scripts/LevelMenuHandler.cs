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
    private Slider masterVolumeSlider, soundEffectsVolumeSlider, backgroundMusicVolumeSlider;
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
        SetSliderValues();
    }

    // public void OpenLevelMenu()
    // {
    //     levelMenu.SetActive(true);

    //     EventSystem.current.SetSelectedGameObject(null);
    //     EventSystem.current.SetSelectedGameObject(levelFirstButton);
    // }

    // public void CloseLevelMenu()
    // {
    //     levelMenu.SetActive(false);

    //     EventSystem.current.SetSelectedGameObject(null);
    //     EventSystem.current.SetSelectedGameObject(levelMenuCloseButton);
    // }

        public void PlayLevelOne()
        {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
        }

        // public void PlayLevelTwo()
        // {
        // SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 2);
        // }

    private void SetSliderValues()
    {
        if (PlayerPrefs.HasKey("masterVolume"))
        {
            masterVolumeSlider.value = PlayerPrefs.GetFloat("masterVolume");
        }
        if (PlayerPrefs.HasKey("soundEffectsVolume"))
        {
            soundEffectsVolumeSlider.value = PlayerPrefs.GetFloat("soundEffectsVolume");
        }
        if (PlayerPrefs.HasKey("backgroundMusicVolume"))
        {
            backgroundMusicVolumeSlider.value = PlayerPrefs.GetFloat("backgroundMusicVolume");
        }
    }
}
