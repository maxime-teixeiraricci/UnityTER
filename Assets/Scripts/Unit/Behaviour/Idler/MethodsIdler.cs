using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class MethodsIdler : Methods, IdlerActions
{

    public void idle()
    {
        NavMeshAgent _navMeshAgent = GetComponent<NavMeshAgent>();
        _navMeshAgent.isStopped = true;
    }
}
