using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PerceptUnit : Percept {

    PerceptUnit()
    {
        _perceptName = "PERCEPT_UNIT";
        _value = false;
        _gameObject = null;
    }

    override public void update()
    {
        Brain brain = GetComponent<Brain>();
        Sight sight = brain.GetComponent<Sight>();
        List<GameObject> _listOfUnitColl = new List<GameObject>();
        foreach(GameObject gO in sight._listOfCollision){
            if(gO.GetComponent<UnitManager>() != null)
            {
                _listOfUnitColl.Add(gO);
            }
        }
        if (_listOfUnitColl.Count > 0)
        {
            _value = true;
            _gameObject = _listOfUnitColl[0];
        }
        else
        {
            _value = false;
            _gameObject = null;
        }
    }

}
