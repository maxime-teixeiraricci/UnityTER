using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PerceptTarget : Percept {

    void Start()
    {
        _perceptName = "PERCEPT_TARGET";
        _value = false;
        _gameObject = null;
    }

    override public void update()
    {
        _value = GetComponent<Brain>().GetComponent<Stats>()._target != null;
    }
}
