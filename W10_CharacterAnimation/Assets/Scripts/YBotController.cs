using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class YBotController : MonoBehaviour
{
    Animator animator;
    NavMeshAgent agent;

    int isWalkingHash;
    int velocityXHash;
    int velocityZHash;

    private void Awake()
    {
        animator = GetComponent<Animator>();
        agent = GetComponent<NavMeshAgent>();

        isWalkingHash = Animator.StringToHash("isWalking");
        velocityXHash = Animator.StringToHash("velocityX");
        velocityZHash = Animator.StringToHash("velocityZ");
    }

    private void Update()
    {
        Vector3 velocity = agent.velocity;

        bool isMoving = velocity.magnitude > 0.01f && agent.remainingDistance > agent.radius;

        animator.SetBool(isWalkingHash, isMoving);

        velocity = transform.InverseTransformVector(velocity);

        animator.SetFloat(velocityXHash, velocity.x);
        animator.SetFloat(velocityZHash, velocity.z);
    }
}
