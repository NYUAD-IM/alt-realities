using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BucketController : MonoBehaviour
{
    public Transform spawn;
    public MeshRenderer bucketRenderer;

    private void OnTriggerEnter(Collider other)
    {
        if(other.gameObject.CompareTag("GrabCube"))
        {
            HighlightController hc = other.gameObject.GetComponent<HighlightController>();
            Color cubeColor = hc.GetBaseColor();

            bucketRenderer.material.color = cubeColor;

            hc.SetBaseColor(Random.ColorHSV());
            other.gameObject.transform.position = spawn.position;
        }
    }

}
