using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.XR;
public class VRmodeon : MonoBehaviour
{
    int vrModeInt;
    public void ToggleVRMode()
    {
        if (PlayerPrefs.GetInt("Cardboad")==1){
            vrModeInt = 0;
        }
        if(PlayerPrefs.GetInt("Vr Mode") == 0)
        {
            vrModeInt = 1;
        }
        PlayerPrefs.SetInt("Vr Mode", vrModeInt);
    }
    private void Update()
    {
        if(PlayerPrefs.GetInt("Vr Mode") == 0)
        {
            XRSettings.enabled = true;
        }
        if(PlayerPrefs.GetInt("Vr Mode") == 1)
        {

        }
    }

}
