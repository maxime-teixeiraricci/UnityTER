using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class ActionSimpleMove : Action
{
    NavMeshAgent _navMeshAgent;

    public override void Do()
    {
        /*
        _navMeshAgent = GetComponent<NavMeshAgent>();
        float heading = GetComponent<UnitManager>()._stats._heading;
        Vector3 vectMove = new Vector3(Mathf.Cos(heading * Mathf.Deg2Rad), 0, Mathf.Sin(heading * Mathf.Deg2Rad));
        _navMeshAgent.destination = transform.position + vectMove.normalized;
        print(_navMeshAgent.destination);
        */
        GetComponent<MovableCharacter>().Move();
    }

}
