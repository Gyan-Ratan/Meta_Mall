using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.VR;
using UnityEngine.XR;
public class CardboardToogle : MonoBehaviour
{
    private bool Show = false;
    public void ToggleVRMode()
    {
        if (!Show)
        {
            XRSettings.enabled = true;
            Show = true;

        }
       else
        {
            XRSettings.enabled = false;
            Show = false;
        }
      
    }

    // Update is called once per frame
    
}