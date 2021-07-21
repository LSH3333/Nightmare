using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class controlling : MonoBehaviour
{
    public float speed = 2f;
    private void Update()
    {
        float hor = Input.GetAxisRaw("Horizontal");
        float ver = Input.GetAxisRaw("Vertical");
        Vector3 dir = new Vector3(hor, ver);

        transform.Translate(dir * speed * Time.deltaTime);
    }
}
