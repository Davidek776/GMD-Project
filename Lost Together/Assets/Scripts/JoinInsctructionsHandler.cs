using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.InputSystem;
using UnityEngine.UI;

public class JoinInsctructionsHandler : MonoBehaviour
{
    private GameObject joinInstructions;
    private GameObject playerControls;
    private PlayerInput playerInput;
    private TextMeshProUGUI joinInstruction1;
    private TextMeshProUGUI joinInstruction2;
    // Start is called before the first frame update
    void Start()
    {
        joinInstructions = GameObject.FindWithTag("JoinInstructions");
        playerControls = GameObject.FindWithTag("PlayerControls");
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
            playerControls.SetActive(true);
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
