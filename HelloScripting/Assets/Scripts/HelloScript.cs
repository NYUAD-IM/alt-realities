using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HelloScript : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        Debug.Log("Hello Start!");
    }

    // Update is called once per frame
    void Update()
    {
        transform.position = new Vector3(Mathf.Sin(Time.time) * 5.0f, 0, 0);
    }
}
