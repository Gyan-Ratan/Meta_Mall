using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.XR;
public class VRmodeon : MonoBehaviour
{
    public void mode()
    {
        XRSettings.LoadDeviceByName("Cardboad");
        XRSettings.enabled = true;
    }
   
}
