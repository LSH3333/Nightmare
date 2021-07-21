using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FixRotation : MonoBehaviour
{
    Quaternion rotation;
    private void Awake()
    {
        rotation = transform.rotation;
    }

    private void LateUpdate()
    {
        transform.rotation = rotation;
    }
}
