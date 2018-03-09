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
        _percepts["PERCEPT_BAG_EMPTY"] = delegate () { return GetComponent<Inventory>()._actualSize == 0; };
        _percepts["PERCPET_CAN_GIVE"] = delegate () 
        {
            return (GetComponent<Stats>()._target != null) && (Vector3.Distance(GetComponent<Stats>()._target.transform.position, transform.position) < 1.5f);
        };
        _percepts["PERCEPT_IS_RELOADED"] = delegate () { return GetComponent<Stats>()._reloadTime <= 0; };
        _percepts["PERCEPT_IS_NOT_RELOADED"] = delegate () { return GetComponent<Stats>()._reloadTime > 0; };
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
