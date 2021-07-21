using UnityEngine;

public class CameraFollow_u : MonoBehaviour
{
    public Transform target;

    public float smoothSpeed = 0.125f;
    public Vector3 offset;

    private void Start()
    {
        // LocalPlayer 태그의 플레이어 
        target = GameObject.FindGameObjectWithTag("LocalPlayer").transform;
    }

    private void Update()
    {
        Vector3 newPos = target.position + offset;
        transform.position = Vector3.Lerp(transform.position, newPos, smoothSpeed);

        transform.LookAt(target);
    }
}
