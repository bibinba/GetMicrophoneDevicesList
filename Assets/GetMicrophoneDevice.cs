using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GetMicrophoneDevice : MonoBehaviour
{
    public Text Text_Device;
    void Start()
    {
        foreach (var device in Microphone.devices)
        {
            Debug.Log("Name: " + device);
            Text_Device.text = Text_Device.text+"\n " + device;
        }
    }

}
