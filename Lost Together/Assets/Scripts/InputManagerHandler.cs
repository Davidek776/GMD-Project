using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class InputManagerHandler : MonoBehaviour
{
    //Player input manager
    private PlayerInputManager playerInputManager;
    private GameObject playerPrefab2;

    // Start is called before the first frame update
    void Start()
    {
        playerInputManager = GetComponent<PlayerInputManager>();
    }

    // Update is called once per frame
    void Update()
    {
        if(GameObject.Find("Player1") != null)
        {
            playerInputManager.playerPrefab = playerPrefab2;
        }
    }
}
