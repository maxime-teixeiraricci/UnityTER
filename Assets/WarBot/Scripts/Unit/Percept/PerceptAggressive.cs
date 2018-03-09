using System.Collections;
using System.Collections.Generic;
using System;
using UnityEngine;

[Serializable]
public class PerceptAggressive : PerceptCommon
{

    void Start()
    {
        InitPercept();
    }


    public new void InitPercept()
    {
        base.InitPercept();
        _percepts["PERCEPT_FOOD"] = delegate ()
        {
            bool res = false;
            _target = null;
            foreach (GameObject gO in GetComponent<Sight>()._listOfCollision)
            {
                if (gO.tag == "Item")
                {
                    _target = gO;
                    res = true;
                    break;
                }
            }
            return res;
        };
        _percepts["PERCEPT_FOOD_NEAR"] = delegate ()
        {
            return (_percepts["PERCEPT_FOOD"]()) && (Vector3.Distance(_target.transform.position, transform.position) < 1.5f);
        };
        _percepts["PERCEPT_ENEMY"] = delegate ()
        {

            Brain brain = GetComponent<Brain>();
            Sight sight = brain.GetComponent<Sight>();
            List<GameObject> _listOfUnitColl = new List<GameObject>();
            GameObject _gameObject = GetComponent<Stats>()._unitTarget;
            int angleEnemy;


            foreach (GameObject gO in sight._listOfCollision)
            {
                if (gO && !_gameObject)
                {
                    if (gO.GetComponent<Stats>() && gO.GetComponent<Stats>()._teamIndex != GetComponent<Stats>()._teamIndex)
                    {
                        _gameObject = gO;
                        angleEnemy = getAngle(_gameObject);
                        GetComponent<Stats>()._heading = getAngle(_gameObject);
                        return true;
                    }
                }
            }
            return false;
        };
    }

}
