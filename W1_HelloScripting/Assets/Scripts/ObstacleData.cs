using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObstacleData : MonoBehaviour
{
    public Color color = Color.white;

    MeshRenderer meshRnderer;

    private void Awake()
    {
        meshRnderer = GetComponent<MeshRenderer>();
    }

    private void Update()
    {
        meshRnderer.material.color = color;
    }
}
