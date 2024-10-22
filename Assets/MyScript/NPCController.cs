using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class NPCController : MonoBehaviour
{
    [SerializeField] private GameObject target;
    private NavMeshAgent _agent;
    private Animator controller;

    private void Start()
    {
        _agent = GetComponent<NavMeshAgent>();
        controller = GetComponent<Animator>();
        _agent.SetDestination(target.transform.position);
            
    }

    private void Update()
    {
        if (controller != null && _agent != null)
        {
            controller.SetFloat("Speed", _agent.velocity.magnitude);
        }
    }
}
