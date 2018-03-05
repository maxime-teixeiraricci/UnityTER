using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PerceptUnit : Percept {

    public PerceptUnit()
    {
        _perceptName = "PERCEPT_UNIT";
        _value = false;
        _gameObject = null;
    }

    override public void update()
    {
        Brain brain = GetComponent<Brain>();
        Sight sight = brain.GetComponent<Sight>();
        List<GameObject> _listOfUnitColl = new List<GameObject>();
        foreach (GameObject gO in sight._listOfCollision){
            UnitManager gOmanager = gO.GetComponent<UnitManager>();
            if (gO.GetComponent<UnitManager>() != null)
            {
                if (!(gOmanager.GetComponent<Stats>()._myTeam == (GetComponent<Stats>()._myTeam)))
                {
                    _listOfUnitColl.Add(gO);
                }
            }
        }
        if (_listOfUnitColl.Count > 0)
        {
            
            
            _gameObject = _listOfUnitColl[0];
            GetComponent<Stats>()._heading = getAngle();
            _value = true;
        }
        else
        {
            _value = false;
            _gameObject = null;
        }
    }

    public int getAngle()
    {
        Vector3 vect = _gameObject.transform.position - transform.position;
        Vector3 projVect = Vector3.ProjectOnPlane(vect, Vector3.up);

        return (int)(360-Vector3.Angle(projVect, new Vector3(1,0,0)));

    }
}
