using System;
using System.Collections;
using UnityEngine;
using UnityEngine.XR;
public class LoadBYName : MonoBehaviour
{
    
   public void Sw()
    {
        SwitchToVR();
    }

    IEnumerator SwitchToVR()
    {
        if (XRSettings.loadedDeviceName != "cardboard")
        {
            XRSettings.LoadDeviceByName("cardboard"); // Or "daydream" (both lowercase).

            // Wait one frame!
            yield return null;

            // Now it's ok to enable VR mode.
            XRSettings.enabled = true;
        }
    }
}
