using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class PlayerNavMesh : MonoBehaviour
{
    [SerializeField] private Transform target;
    [SerializeField] private NavMeshAgent agent;
    // void Awake()
    // {
    //     NavMeshAgent agent = GetComponent<NavMeshAgent>();
    // }

    private void Update()
    {
        agent.SetDestination(target.position);
    }
}
