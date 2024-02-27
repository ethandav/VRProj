using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class NavMeshDestination : MonoBehaviour
{
    public Transform target; // Assign the target in the inspector
    private NavMeshAgent agent;

    void Start()
    {
        agent = GetComponent<NavMeshAgent>();
    }

    void Update()
    {
        // Set the destination of the NavMesh Agent to the target's position
        agent.SetDestination(target.position);
    }
}
