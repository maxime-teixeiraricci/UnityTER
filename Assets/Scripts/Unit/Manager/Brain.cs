using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Brain : MonoBehaviour
{
    public ActionManager[] _actions;
    public bool _debugShoot;



    void Update()
    {
        /*PerceptStructure[] listePercepts = GetComponent<UnitManager>().GetComponent<PerceptManager>()._percepts;
        if (!listePercepts[0]._percept._value)
            _actions[0].Do(); // Move*/
        _actions[0].Do();
        if (_debugShoot)
        {
            _actions[1].Do();
            _debugShoot = false;
        }
    }

}
