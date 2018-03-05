using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PerceptObjectif : Percept {

    void Start()
    {
        _perceptName = "PERCEPT_OBJECTIF";
        _value = false;
        _gameObject = null;
    }

    override public void update()
    {
        _value = GetComponent<Brain>().GetComponent<Stats>()._objectif != null;
    }
}
