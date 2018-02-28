using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PerceptRessource : Percept
{
    public Brain brain;
    public Sight sight;

    void Start()
    {
        Brain brain = GetComponent<Brain>();
        Sight sight = brain.GetComponent<Sight>();
    }

    PerceptRessource()
    {
        _perceptName = "PERCEPT_RESSOURCE";
        _value = false;
        _gameObject = null;
    }

    override public void update()
    {
        List<GameObject> _listOfRessourceColl = new List<GameObject>();
        foreach (GameObject gO in sight._listOfCollision)
        {
            if (gO.GetComponent<ItemHeldler>() != null)
            {
                _gameObject = gO;
                _value = true;
                break;
            }
        }
            _value = false;
            _gameObject = null;
    }

}
