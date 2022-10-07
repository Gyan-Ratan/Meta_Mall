using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.VR;
using UnityEngine.XR;
public class CardboardToogle : MonoBehaviour
{
    int vrModeInt;
    private bool Show = false;
    public void ToggleVRMode()
    {
        if (Show==false)
        {
            XRSettings.enabled = true;
            Show = true;
        }
        if (Show==true)
        {
            XRSettings.enabled = false;
            Show = false;
        }
    }
    void Update()
    {
        
    }
    // Update is called once per frame

}