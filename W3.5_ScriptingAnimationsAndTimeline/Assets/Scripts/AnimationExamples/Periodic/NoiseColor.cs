using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NoiseColor : MonoBehaviour
{
    MeshRenderer meshRenderer = null;

    public float speed = 1;

    // Start is called before the first frame update
    void Start()
    {
        meshRenderer = GetComponent<MeshRenderer>();
    }

    // Update is called once per frame
    void Update()
    {
        float n = Mathf.PerlinNoise(Time.time * speed, Time.time * speed);
        meshRenderer.material.color = Color.HSVToRGB(n, 1, 1);
    }
}
