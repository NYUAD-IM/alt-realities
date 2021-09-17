using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RandomColor : MonoBehaviour
{
    MeshRenderer meshRenderer = null;

    // Start is called before the first frame update
    void Awake()
    {
        meshRenderer = GetComponent<MeshRenderer>();
    }

    public void SetColor()
    {
        if(meshRenderer != null)
            meshRenderer.material.color = Random.ColorHSV();
    }

    public void SetColor(int c)
    {
        if (meshRenderer != null)
            meshRenderer.material.color = new Color(c, c, c);
    }
}
