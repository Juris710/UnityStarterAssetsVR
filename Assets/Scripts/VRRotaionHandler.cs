using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;
using UnityEngine.InputSystem.Controls;
public class VRRotaionHandler : MonoBehaviour
{
    [SerializeField] Transform cameraOffset;
    [SerializeField] Transform playerCapsule;
    private void Update()
    {
        var localRotation = transform.localRotation;
        playerCapsule.localRotation = new Quaternion(playerCapsule.localRotation.x, localRotation.y, playerCapsule.localRotation.z, localRotation.w);
        var inverse = Quaternion.Inverse(localRotation);
        var offsetRotation = cameraOffset.localRotation;
        offsetRotation.w = inverse.w;
        offsetRotation.y = inverse.y;
        cameraOffset.localRotation = offsetRotation;
    }
}
