using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;


public class OptionsMenuHandler : MonoBehaviour
{
    public static OptionsMenuHandler instance;

    [SerializeField]
    private GameObject optionsMenu
;
    [SerializeField]
    private GameObject optionsFirstButton, optionsCloseButton;
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
        optionsMenu.SetActive(false);
        SetSliderValues();
    }

    public void OpenOptionsMenu()
    {
        optionsMenu.SetActive(true);
        EventSystem.current.SetSelectedGameObject(null);
        EventSystem.current.SetSelectedGameObject(optionsFirstButton);
    }

    public void CloseOptionsMenu()
    {
        optionsMenu.SetActive(false);
        EventSystem.current.SetSelectedGameObject(null);
        EventSystem.current.SetSelectedGameObject(optionsCloseButton);
    }

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
