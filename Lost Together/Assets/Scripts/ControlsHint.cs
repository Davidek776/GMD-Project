using UnityEngine;
using System.Collections;
using UnityEngine.InputSystem;

public class ControlsHint : MonoBehaviour
{
    public GameObject controlsHint;
    public bool hintDisabled = false;

    // Start is called before the first frame update
    void Start()
    {
        controlsHint.SetActive(true);
    }

    public void DisableHint()
    {
        controlsHint.SetActive(false);
        hintDisabled = true;
    }
}
