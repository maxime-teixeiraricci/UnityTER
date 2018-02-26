using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Brain : MonoBehaviour
{
    public Instruction[] _instructions;
    public ActionStructure[] _actionsPossibles; //non pris en compte pour le moment.

    void Update()
    {

        ActionStructure[] listeActionsPossibles = GetComponent<UnitManager>().GetComponent<ActionManager>()._actions;

        foreach(Instruction instru in _instructions)
        {
            if (instru.verify())
            {
                break;
            }
        }
    }

}
