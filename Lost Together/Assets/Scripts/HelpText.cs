using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HelpText : MonoBehaviour
{
    void Start()
    {
        gameObject.SetActive(false);
    }

    public void Show()
    {
        gameObject.SetActive(true);
        Invoke("HideAfterDelay", 3f);
    }

    void HideAfterDelay()
    {
        gameObject.SetActive(false);
    }
}
