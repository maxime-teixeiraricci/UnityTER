using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Brain : MonoBehaviour
{
    public ActionManager[] _actions;


    void Update()
    {
        _actions[0].Do();
    }

}
