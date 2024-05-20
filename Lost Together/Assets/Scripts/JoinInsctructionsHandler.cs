using TMPro;
using UnityEngine;
using UnityEngine.InputSystem;

public class JoinInsctructionsHandler : MonoBehaviour
{
    private GameObject joinInstructions;
    private PlayerInput playerInput;
    private TextMeshProUGUI joinInstruction1;
    private TextMeshProUGUI joinInstruction2;
    
    void Start()
    {
        PauseMenu.instance.PauseGameWithoutMenu();
        joinInstructions = GameObject.FindWithTag("JoinInstructions");
        playerInput = GetComponent<PlayerInput>();

        if (playerInput.playerIndex == 0)
        {
            joinInstruction1  = joinInstructions.transform.GetChild(1).GetComponent<TextMeshProUGUI>();
            joinInstruction1.alpha = 255;
        }
        else if (playerInput.playerIndex == 1)
        {
            joinInstruction2 = joinInstructions.transform.GetChild(2).GetComponent<TextMeshProUGUI>();
            joinInstruction2.alpha = 255;
            joinInstructions.SetActive(false);
            PauseMenu.instance.ResumeGame();
        }
    }
}
