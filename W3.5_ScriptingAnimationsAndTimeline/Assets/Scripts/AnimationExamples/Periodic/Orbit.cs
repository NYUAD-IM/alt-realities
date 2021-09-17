using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Orbit : MonoBehaviour
{
    public Transform pivot = null;
    public Vector3 axis = Vector3.one;
    public float speed = 1f;
    public float attract = 1f;
    public float maxDistance = 5f;

    // Update is called once per frame
    void Update()
    {
        transform.RotateAround(pivot.position, axis, speed * Time.deltaTime);
        Vector3 delta = pivot.position - transform.position;
        if(delta.magnitude > maxDistance)
        {
            delta.Normalize();
            delta *= maxDistance;
            transform.position = Vector3.MoveTowards(transform.position, pivot.position + delta, attract * Time.deltaTime);
        }
    }
}
