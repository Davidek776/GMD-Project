using UnityEngine;
public class Door : MonoBehaviour, ISwitchable
{
    private bool isOpen = false; 

    // Implement ISwitchable methods
    public void Activate()
    {
        isOpen = true;
        // Debug.Log("Door Activated");
    }

    public void Deactivate()
    {
        isOpen = false;
        // Debug.Log("Door Deactivated");
    }

    public bool IsActive()
    {
        return isOpen;
    }
}
