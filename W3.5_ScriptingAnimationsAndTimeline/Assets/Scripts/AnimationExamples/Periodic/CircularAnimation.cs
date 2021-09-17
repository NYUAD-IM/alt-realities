using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CircularAnimation : MonoBehaviour
{ 
    public float radius = 2.0f;
    public float speed = 1.0f;

    // Update is called once per frame
    void Update()
    {
        transform.localPosition = new Vector3(
             radius * Mathf.Cos(Time.time * speed),
             0,
             radius * Mathf.Sin(Time.time * speed)
             );
    }

}
