using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace AYellowpaper.Samples{
public interface ISwitchable
{
  public bool IsActive { get; }
public void Activate();
 public void Deactivate();
}
}