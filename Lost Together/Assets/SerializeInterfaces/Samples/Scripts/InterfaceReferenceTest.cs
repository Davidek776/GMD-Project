using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace AYellowpaper.Samples{

public class InterfaceReferenceTest : MonoBehaviour
{
    public InterfaceReference<IInteractable> Interactable;
    public InterfaceReference<IInteractable, ScriptableObject> InteractableScriptableObject;
    public InterfaceReference<IInteractable, MonoBehaviour> InteractableComponent;
}
}