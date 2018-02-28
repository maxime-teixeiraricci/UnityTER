using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PerceptRessource : Percept
{
    private Brain brain;
    private Sight sight;

    void Start()
    {
        brain = GetComponent<Brain>();
        sight = brain.GetComponent<Sight>();
    }

    PerceptRessource()
    {
        _perceptName = "PERCEPT_RESSOURCE";
        _value = false;
        _gameObject = null;
    }

    override public void update()
    {
        bool res = false;
        _gameObject = null;
        foreach (GameObject gO in GetComponent<Sight>()._listOfCollision)
        {
            if (gO && gO.GetComponent<ItemHeldler>())
            {
                _gameObject = gO;
                res = true;
                break;
            }
        }
        _value = res;
    }

}
