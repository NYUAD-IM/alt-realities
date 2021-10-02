using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FloorTimeout : MonoBehaviour
{
    public float timeoutDuration = 5.0f;
    public Transform spawn;

    Coroutine timeout;

    private void OnCollisionEnter(Collision collision)
    {
        if(collision.gameObject.CompareTag("Floor"))
        {
            //start a timer!
            timeout = StartCoroutine(Timeout());
        }
    }

    IEnumerator Timeout()
    {
        yield return new WaitForSeconds(timeoutDuration);

        transform.position = spawn.position;
    }

    public void ClearTimeout()
    {
        if (timeout != null) StopCoroutine(timeout);
    }

}
