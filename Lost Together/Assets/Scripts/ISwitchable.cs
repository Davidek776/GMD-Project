using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace AYellowpaper.Samples{
public interface ISwitchable
{
    void Activate();
    void Deactivate();
    bool IsActive();
}
}