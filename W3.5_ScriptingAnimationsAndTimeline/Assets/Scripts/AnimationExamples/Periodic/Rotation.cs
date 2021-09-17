using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Rotation : MonoBehaviour
{
    public float speed = 1f;
    public Vector3 axis = Vector3.one;

    // Update is called once per frame
    void Update()
    {
        transform.localEulerAngles = axis * Time.time * speed;
    }
}
