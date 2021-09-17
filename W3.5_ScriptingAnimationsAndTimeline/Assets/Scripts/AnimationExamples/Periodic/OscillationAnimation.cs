using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OscillationAnimation : MonoBehaviour
{
    public float speed = 1;
    public float radius = 5f;
    public Vector3 axis = Vector3.one;

    // Update is called once per frame
    void Update()
    {
        transform.localPosition = axis * (radius * Mathf.Sin(Time.time * speed));
    }
}
