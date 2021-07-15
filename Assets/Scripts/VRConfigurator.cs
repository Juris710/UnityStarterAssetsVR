using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;
using Cinemachine;
using System.Linq;
public class VRConfigurator : MonoBehaviour
{
    [SerializeField] PlayerInput playerInput;
    [SerializeField] CinemachineVirtualCamera cinemachineVirtualCamera;
    [SerializeField] VRHeadPosition vrHeadPosition;
    [SerializeField] VRRotaionHandler vrRotaionHandler;
    void Start()
    {
        var foundControllers = new List<UnityEngine.XR.InputDevice>();
        UnityEngine.XR.InputDevices.GetDevices(foundControllers);
        if (foundControllers.Count == 0)
        {
            return;
        }
        playerInput.actions.First(a => a.name == "Look").Disable();
        cinemachineVirtualCamera.DestroyCinemachineComponent<CinemachineBasicMultiChannelPerlin>();
        vrHeadPosition.enabled = true;
        vrRotaionHandler.enabled = true;
    }
}
