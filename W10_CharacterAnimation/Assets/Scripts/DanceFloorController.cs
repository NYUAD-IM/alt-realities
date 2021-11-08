using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DanceFloorController : MonoBehaviour
{

    int isDancingHash;

    private void Awake()
    {
        isDancingHash = Animator.StringToHash("isDancing");
    }

    private void OnTriggerEnter(Collider other)
    {
        if(other.gameObject.CompareTag("ybot"))
        {
            Animator animator = other.gameObject.GetComponentInParent<Animator>();
            animator.SetBool(isDancingHash, true);
        }
    }

    private void OnTriggerExit(Collider other)
    {
        if (other.gameObject.CompareTag("ybot"))
        {
            Animator animator = other.gameObject.GetComponentInParent<Animator>();
            animator.SetBool(isDancingHash, false);
        }
    }
}
