using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Brain : MonoBehaviour
{
    public ActionStructure[] _actions;
    public InstructionScriptable[] _instructions;
    public bool _debugShoot;



    void Update()
    {
        foreach(InstructionScriptable instr in _instructions)
        {
            Action actionPossible = this.actionPossible(instr._stringAction);
            if (actionPossible != null && instr.verify(GetComponent<UnitManager>().GetComponent<PerceptManager>()._percepts))
            {
                actionPossible.Do();
                print("" + actionPossible.ToString());
                break;
            }
        }

        /*PerceptStructure[] listePercepts = GetComponent<UnitManager>().GetComponent<PerceptManager>()._percepts;
        if (!listePercepts[0]._percept._value)
            _actions[0].Do(); // Move*/
        
        
        /*_actions[0].Do();
        if (_debugShoot)
        {
            _actions[1].Do();
            _debugShoot = false;
        }*/
    }

    public Action actionPossible(string stringAct)
    {
        Action presence = null;
        foreach (ActionStructure actStruc in _actions)
        {
            if (actStruc._name.Equals(stringAct))
            {
                presence = actStruc._action;
            }
        }
        return presence;
    }

}
