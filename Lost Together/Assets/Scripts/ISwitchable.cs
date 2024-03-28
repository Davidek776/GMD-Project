using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public abstract class ISwitchable:MonoBehaviour
{
public abstract bool IsActive { get; }
public abstract void Activate();
 public abstract void Deactivate();
}