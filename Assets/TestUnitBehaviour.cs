using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityTER.Interpreter;

public class TestUnitBehaviour : MonoBehaviour
{

	// Use this for initialization
	void Start ()
    {
        List<Instruction> behavior = new List<Instruction>(){
            new Instruction(new string[] { "PERCEPT_ENEMY" }, "ACTION_IDLE"),
            new Instruction(new string[] { "PERCEPT_BLOCKED" }, "ACTION_RANDOM_MOVE"),
            new Instruction(new string[] { }, "ACTION_MOVE") };
        string gamePath = "./teams/" + GetComponent<GameManager>()._gameName + "/";

        string teamName = GetComponent<TeamManager>()._teams[0]._name;
        XMLWarbotInterpreter interpreter = new XMLWarbotInterpreter();
        interpreter.behaviorToXml(teamName, gamePath, "Unit", behavior);
    }
	
	// Update is called once per frame
	void Update () {
		
	}
}
