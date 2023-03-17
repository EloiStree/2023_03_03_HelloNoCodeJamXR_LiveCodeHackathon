using System;
using UnityEngine;
using UnityEngine.AI;

[RequireComponent(typeof(NavMeshAgent))]
public class NavAgentMovement : MonoBehaviour
{
    public Transform destination; // The destination to move to

    public NavMeshAgent navAgent; // Reference to the NavMesh Agent component

    void Update()
    {
        if(navAgent != null && destination!=null) 
            SetDestination();
    }

    void SetDestination()
    {
        if (destination != null)
        {
            Vector3 targetVector = destination.transform.position;
            navAgent.SetDestination(targetVector);
        }
    }

    internal void FollowThisTarget(Transform whatToFollow)
    {
        destination = whatToFollow;
    }
}