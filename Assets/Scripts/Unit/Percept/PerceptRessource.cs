using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PerceptRessource : Percept
{

    PerceptRessource()
    {
        _perceptName = "PERCEPT_RESSOURCE";
        _value = false;
        _gameObject = null;
    }

    override public void update()
    {
        Brain brain = GetComponent<Brain>();
        Sight sight = brain.GetComponent<Sight>();
        List<GameObject> _listOfRessourceColl = new List<GameObject>();
        foreach (GameObject gO in sight._listOfCollision)
        {
            if (gO.GetComponent<ItemBehavior>() != null)
            {
                _listOfRessourceColl.Add(gO);
            }
        }
        if (_listOfRessourceColl.Count > 0)
        {
            _value = true;
            _gameObject = _listOfRessourceColl[0];
        }
        else
        {
            _value = false;
            _gameObject = null;
        }
    }

}
