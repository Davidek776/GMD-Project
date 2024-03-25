using UnityEngine;
public interface ISwitchableBase
{
    void Activate();
    void Deactivate();
    bool IsActive();
}