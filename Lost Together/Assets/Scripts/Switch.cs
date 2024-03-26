using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace AYellowpaper.Samples{
public class Switch : MonoBehaviour
{
public InterfaceReference<ISwitchable, MonoBehaviour> client;

 public void Toggle()
 {
 if (client.IsActive)
 {
 client.Deactivate();
 }
 else
 {
 client.Activate();
 }
 }
}
}