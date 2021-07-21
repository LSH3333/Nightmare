using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class camfol : MonoBehaviour
{
    public Transform target;
    public Camera cam;

    public float smoothSpeed = 0.125f;
    public Vector3 offset;

    private void FixedUpdate()
    {
        Vector3 newPos = target.position + offset;
        cam.transform.position = Vector3.Lerp(cam.transform.position, newPos, smoothSpeed);

        cam.transform.LookAt(target);
    }
}
