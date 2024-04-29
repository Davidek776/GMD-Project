using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HelpText : MonoBehaviour
{
    public bool isActive;

    void Start()
    {
        isActive = false;
        gameObject.SetActive(false);
    }

    public void Show()
    {
        isActive = true;
        gameObject.SetActive(true);
        Invoke("Hide", 3f);
    }

    public void Hide()
    {
        gameObject.SetActive(false);
    }
}
