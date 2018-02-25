using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class Stats : MonoBehaviour
{
    public float _heading;
    public Team _myTeam;
    public bool _isBlocked;
    //public Dictionary<string, Object> stats;

    void Update()
    {
        _heading = -transform.eulerAngles.y + 90;
        _isBlocked = GetComponent<MovableCharacter>()._isblocked;
        if (_isBlocked)
        {
            transform.eulerAngles = new Vector3(0,Random.Range(0, 360),0);
        }
    }
}
