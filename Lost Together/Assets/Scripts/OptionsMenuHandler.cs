using UnityEngine;
using UnityEngine.EventSystems;


public class OptionsMenuHandler : MonoBehaviour
{
    public static OptionsMenuHandler instance;

    [SerializeField]
    private GameObject optionsMenu;
    [SerializeField]
    private GameObject optionsFirstButton, optionsCloseButton;

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
}
