using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.VR;
public class CardBoardToggle : MonoBehaviour
{
    int vrModeInt;
    public void ToggleVRMode()
    {
        if (PlayerPrefs.GetInt("Vr Mode") == 1)
        {
            vrModeInt = 0;
        }
        if (PlayerPrefs.GetInt("Vr Mode") == 0)
        {
            vrModeInt = 1;
        }
        PlayerPrefs.SetInt("Vr Mode", vrModeInt);
    }

    // Update is called once per frame
    void Update()
    {
        if (PlayerPrefs.GetInt("Vr Mode") == 1)
        {
            CardBoard.SDK.VRModeEnabled = true;
        }
        if (PlayerPrefs.GetInt("Vr Mode") == 0)
        {
            CardBoard.SDK.VRModeEnabled = false;
        }
    }
}