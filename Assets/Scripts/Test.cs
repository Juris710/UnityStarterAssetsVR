using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.Linq;

public class Test : MonoBehaviour
{
    [SerializeField] List<GameObject> objs;
    [SerializeField] TextMesh txt;
    [SerializeField] Transform mainCamera;

    void Update()
    {
        txt.text = string.Join("\n", objs.Select(o => $"{o.name}:{o.transform.localRotation.w:F2},{o.transform.localRotation.x:F2},{o.transform.localRotation.y:F2},{o.transform.localRotation.z:F2}"));
        txt.text += $"\n{mainCamera.rotation.w:F2},{mainCamera.rotation.x:F2},{mainCamera.rotation.y:F2},{mainCamera.rotation.z:F2}\n";
        txt.text += $"{mainCamera.localPosition}\n";
    }
}
