using System;
using System.Collections;
using UnityEngine;
using UnityEngine.XR;
public class LoadBYName : MonoBehaviour
{

    public void VerifyDeviceName(string newDeviceName)
    {
        if (newDeviceName == "none")
        {
            Debug.Log("Will load none device");
            StartCoroutine(LoadDevice(newDeviceName));

        }
        if (newDeviceName == "cardboard")
        {
            Debug.Log("Will load cardboard device");
            StartCoroutine(LoadDevice(newDeviceName));
        }
        else
        {
            Debug.Log("Can't find device with name " + newDeviceName);
        }

    }

    IEnumerator LoadDevice(string newDeviceName)
    {
        XRSettings.LoadDeviceByName(newDeviceName);
        yield return new WaitForSeconds(10);
        XRSettings.enabled = true;
        Debug.Log("Loaded " + newDeviceName);
    }
}
