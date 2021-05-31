using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class Navmove : MonoBehaviour
{
    public NavMeshAgent agent;
    public Transform follwer;
    void Start()
    {
        agent = GetComponent<NavMeshAgent>();
    }

    // Update is called once per frame
    void Update()
    {
        agent.destination = follwer.position;
    }
}
