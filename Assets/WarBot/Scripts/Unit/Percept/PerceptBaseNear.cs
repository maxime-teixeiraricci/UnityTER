using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PerceptBaseNear : Percept {

    private Brain brain;
    private Sight sight;

    void Start()
    {
        brain = GetComponent<Brain>();
        sight = brain.GetComponent<Sight>();
    }

    PerceptBaseNear()
    {
        _perceptName = "PERCEPT_BASE_NEAR";
        _value = false;
        _gameObject = null;
    }

    override public void update()
    {
        bool res = false;
        _gameObject = null;
        foreach (GameObject gO in GetComponent<Sight>()._listOfCollision)
        {
            if (gO && gO.GetComponent<Stats>()._unitType == "base" && Vector3.Distance(transform.position, gO.transform.position) < 1.75f)
            {
                _gameObject = gO;
                res = true;
                break;
            }
        }
        _value = res;
    }
}
