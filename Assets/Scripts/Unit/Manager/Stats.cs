using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Stats : MonoBehaviour
{
    public float _heading;
    public Team _myTeam;
    //public Dictionary<string, Object> stats;

    void Update()
    {
        _heading = -transform.eulerAngles.y + 90;
    }
}
