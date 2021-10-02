using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LaunchController : MonoBehaviour
{
    public GameObject projectilePrefab;
    public float launchForce = 100.0f;
    public Transform launchSpawn;

    public void Launch()
    {
        GameObject projectile = GameObject.Instantiate(projectilePrefab, launchSpawn.position, launchSpawn.rotation);
        Rigidbody rb = projectile.GetComponent<Rigidbody>();
        rb.AddForce(projectile.transform.forward * launchForce);

        HighlightController hc = projectile.GetComponent<HighlightController>();
        hc.SetBaseColor(Random.ColorHSV());
    }
}
