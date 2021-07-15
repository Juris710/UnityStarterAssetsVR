using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;
using UnityEngine.InputSystem.Controls;

public class MockVRRotation : MonoBehaviour
{
    void Update()
    {
        if (Keyboard.current.numpad0Key.isPressed)
        {
            transform.localRotation = new Quaternion(0, 0, 0, 1);
        }
        transform.Rotate(new Vector3(
        ((Keyboard.current.numpad2Key.isPressed ? 1 : 0) - (Keyboard.current.numpad8Key.isPressed ? 1 : 0)) * Time.deltaTime * 20,
        ((Keyboard.current.numpad6Key.isPressed ? 1 : 0) - (Keyboard.current.numpad4Key.isPressed ? 1 : 0)) * Time.deltaTime * 20,
        ((Keyboard.current.numpad7Key.isPressed ? 1 : 0) - (Keyboard.current.numpad9Key.isPressed ? 1 : 0)) * Time.deltaTime * 20
        ));
    }
}
