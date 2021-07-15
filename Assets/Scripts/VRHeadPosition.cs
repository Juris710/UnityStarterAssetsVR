using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class VRHeadPosition : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        var p = transform.localPosition;
        p.y = 0;
        transform.localPosition = p;
    }
}
