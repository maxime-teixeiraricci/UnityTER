using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class MethodsMovable : Methods, MoveActions
{
    public void move()
    {
        NavMeshAgent _navMeshAgent = GetComponent<NavMeshAgent>();
        
        _navMeshAgent.isStopped = false;
        float h = Mathf.Deg2Rad * GetComponent<UnitManager>()._stats._heading;
        Vector3 dest = transform.position + new Vector3(Mathf.Sin(h), 0, Mathf.Cos(h)).normalized;
        Debug.DrawLine(transform.position, dest, Color.green);
        _navMeshAgent.destination = dest;
    }

}
