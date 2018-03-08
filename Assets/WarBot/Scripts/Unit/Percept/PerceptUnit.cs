﻿using System.Collections;
using System.Collections.Generic;
using System;
using UnityEngine;

[Serializable]
public class PerceptUnit : MonoBehaviour
{
    public delegate bool Listener();
    public GameObject _target;


    public Dictionary<string, Listener> _percepts = new Dictionary<string, Listener> ();


    void Start()
    {
        _percepts["PERCEPT_LIFE_MAX"] = delegate () { return GetComponent<Stats>()._maxHealth == GetComponent<Stats>()._health; };
        _percepts["PERCEPT_BLOCKED"] = delegate () { return GetComponent<Stats>()._isBlocked; };
        _percepts["PERCEPT_LIFE_NOT_MAX"] = delegate () { return GetComponent<Stats>()._maxHealth != GetComponent<Stats>()._health; };
        _percepts["PERCEPT_BAG_FULL"] = delegate () { return GetComponent<Inventory>()._maxSize == GetComponent<Inventory>()._actualSize; };
        _percepts["PERCEPT_BASE_NEAR"] = delegate ()
        {
            bool res = false;
            _target = null;
            foreach (GameObject gO in GetComponent<Sight>()._listOfCollision)
            {
                if (gO.GetComponent<Stats>() != null && gO.GetComponent<Stats>()._unitType == "base" && Vector3.Distance(transform.position, gO.transform.position) < 3.5f)
                {
                    _target = gO;
                    res = true;
                    break;
                }
            }
            return res;
        };
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
    }

}
