using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PerceptLifeNotMax : Percept
{
   

    void Start()
    {
        _perceptName = "PERCEPT_LIFE_NOT_MAX";
        _value = false;
        _gameObject = null;
    }

    override public void update()
    {
        _value = GetComponent<Brain>().GetComponent<Stats>()._health != GetComponent<Brain>().GetComponent<Stats>()._maxHealth;
    }

}