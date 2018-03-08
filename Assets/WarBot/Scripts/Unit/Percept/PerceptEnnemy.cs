using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PerceptEnnemy : Percept
{
    [SerializeField()]
    public int angleEnemy;

    public PerceptEnnemy()
    {
        _perceptName = "PERCEPT_ENEMY";
        _value = false;
        _gameObject = null;
        
    }

    override public void update()
    {
        Brain brain = GetComponent<Brain>();
        Sight sight = brain.GetComponent<Sight>();
        List<GameObject> _listOfUnitColl = new List<GameObject>();
        _value = false;
        _gameObject = null;
        

        foreach (GameObject gO in sight._listOfCollision)
        {
            if (gO && !_gameObject)
            {
                
                UnitManager gOmanager = gO.GetComponent<UnitManager>();
                if (gO.GetComponent<UnitManager>() != null)
                {
                    
                    if (gOmanager.GetComponent<Stats>() && gOmanager.GetComponent<Stats>()._teamIndex != GetComponent<Stats>()._teamIndex)
                    {
                        _gameObject = gO;
                        angleEnemy = getAngle();
                        GetComponent<Stats>()._heading = getAngle();
                        _value = true;
                        break;
                    }
                }
            }
        }
    }

    public int getAngle()
    {
        Vector3 vect = _gameObject.transform.position - transform.position;
        Vector3 projVect = Vector3.ProjectOnPlane(vect, Vector3.up);

        if (projVect.z > 0)
        {
            return (int)(360 - Vector3.Angle(projVect, new Vector3(1, 0, 0)));
        }
        return (int)(Vector3.Angle(projVect, new Vector3(1, 0, 0)));

    }
}
