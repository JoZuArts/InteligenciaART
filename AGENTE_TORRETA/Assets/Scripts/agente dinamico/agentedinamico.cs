using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;


public class agentedinamico : MonoBehaviour
{
    NavMeshAgent agent;

    public Transform waypoint;

    // Start is called before the first frame update
    void Start()
    {
        agent = GetComponent<NavMeshAgent>();

        agent.SetDestination(waypoint.position);
    }


    // Update is called once per frame
    void Update()
    {
        
    }
}
