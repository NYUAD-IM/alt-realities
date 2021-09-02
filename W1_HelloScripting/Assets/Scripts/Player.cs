using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    public float speed = 10.0f;

    Rigidbody body;
    MeshRenderer meshRenderer;

    // Start is called before the first frame update
    void Start()
    {
        body = GetComponent<Rigidbody>();
        meshRenderer = GetComponent<MeshRenderer>();
    }

    // Update is called once per frame
    void Update()
    {
        Vector3 randDir = Random.onUnitSphere;
        body.AddForce(new Vector3(randDir.x, 0, randDir.y) * speed);
    }


    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.CompareTag("obstacle"))
        {
            ObstacleData data = collision.gameObject.GetComponent<ObstacleData>();
            if(data != null)
            {
                meshRenderer.material.color = data.color;
            }
            Debug.Log("Collision start: " + collision.gameObject.name);
        }
    }

}
