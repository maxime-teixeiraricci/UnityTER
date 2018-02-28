using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PerceptRessourceNear : Percept
{

    void Start()
    {
        _perceptName = "PERCEPT_RESSOURCE_NEAR";
        _value = false;
        _gameObject = null;
    }

    override public void update()
    {
        if (GetComponent<PerceptRessource>()._gameObject)
        {
            _value = Vector3.Distance(transform.position, GetComponent<PerceptRessource>()._gameObject.transform.position) < 1.75f;
        }
        else
        {
            _value = false;
        }
        
    }

}