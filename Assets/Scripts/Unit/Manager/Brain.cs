using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Brain : MonoBehaviour
{
    public ActionManager[] _actions;


    void Awake()
    {
        foreach (ActionManager a in _actions)
        {
            a._action._target = gameObject;
        }
    }

    void Update()
    {
        _actions[0].Do();
    }

}
