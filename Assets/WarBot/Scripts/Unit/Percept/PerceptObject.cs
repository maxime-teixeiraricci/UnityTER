using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PerceptObject : Percept {

    PerceptObject()
    {
        _perceptName = "PERCEPT_OBJECT";
        _value = false;
        _gameObject = null;
    }

    override public void update()
    {
        Brain brain = GetComponent<Brain>();
        Sight sight = brain.GetComponent<Sight>();
        if(sight._listOfCollision.Count > 0)
        {
            _value = true;
            _gameObject = sight._listOfCollision[0];
        }
        else
        {
            _value = false;
            _gameObject = null;
        }
    }
}
