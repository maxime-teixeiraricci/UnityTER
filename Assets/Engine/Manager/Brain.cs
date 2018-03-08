using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Brain : MonoBehaviour
{
    
    public List<Instruction> _instructions;
    public PerceptUnit _percepts;
    public ActionUnit _actions;
    private string _currentAction;

    [ExecuteInEditMode]
    void Start()
    {
        //GameObject.Find("Canvas").GetComponent<HUDManager>().CreateHUD(gameObject);
        _instructions = GameObject.Find("GameManager").GetComponent<TeamManager>().getUnitsBevahiours(GetComponent<Stats>()._teamIndex, GetComponent<Stats>()._unitType);
        print("Nombre Instruction : " + _instructions.Count);
        _percepts = GetComponent<PerceptUnit>();
        _actions = GetComponent<ActionUnit>();
    }

    void Update()
    {
        if (_instructions != null)
        {
            string _action = NextAction();
            _actions._actions[_action]();
        }
    }

    public string NextAction()
    {
        foreach (Instruction instruction in _instructions)
        {
            if (Verify(instruction)) { return instruction._stringAction; }
        }
        return "ACTION_IDLE";
    }

    bool Verify(Instruction instruction)
    {
        foreach(string percept in instruction._listeStringPerceptsVoulus)
        {
            if ( !(_percepts._percepts.ContainsKey(percept) && _percepts._percepts[percept]()) ) { return false; }
        }
        return true;
    }

    

}
