using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PerceptCommon : Percept
{
    void Start()
    {
        InitPercept();
    }


    public void InitPercept()
    {
        _percepts["PERCEPT_LIFE_MAX"] = delegate () { return GetComponent<Stats>()._maxHealth == GetComponent<Stats>()._health; };
        _percepts["PERCEPT_BLOCKED"] = delegate () { return GetComponent<Stats>()._isBlocked; };
        _percepts["PERCEPT_LIFE_NOT_MAX"] = delegate () { return GetComponent<Stats>()._maxHealth != GetComponent<Stats>()._health; };
        _percepts["PERCEPT_BAG_FULL"] = delegate () { return GetComponent<Inventory>()._maxSize == GetComponent<Inventory>()._actualSize; };
        _percepts["PERCEPT_BASE_NEAR"] = delegate ()
        {
            _target = null;
            foreach (GameObject gO in GetComponent<Sight>()._listOfCollision)
            {
                if (gO.GetComponent<Stats>() != null && gO.GetComponent<Stats>()._unitType == "base" && Vector3.Distance(transform.position, gO.transform.position) < 3.5f)
                {
                    _target = gO;
                    return true;
                }
            }
            return false;
        };
       
    }
}
