using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityTER.Interpreter;

public class UnitBehaviourManager : MonoBehaviour
{
    public List<string> _unitsTypes = new List<string>();
    public Dictionary<string, List<Instruction>> _behaviours = new Dictionary<string, List<Instruction>>();

    void Start()
    {
        XMLWarbotInterpreter interpreter = new XMLWarbotInterpreter();
        GameManager GM = GetComponent<GameManager>();

        string gamePath = "./teams/" + GetComponent<GameManager>()._gameName + "/";


        foreach (string type in _unitsTypes)
        {
            interpreter.xmlToUnitBehavior(GetComponent<TeamManager>()._teams[0]._name, gamePath + Constants.teamsDirectory, type);
        }
    }
}
