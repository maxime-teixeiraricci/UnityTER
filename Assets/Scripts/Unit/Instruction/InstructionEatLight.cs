using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InstructionEatLight : Instruction
{

    public InstructionEatLight()
    {
        string[] listePercepts = new string[1];
        string action;
        action = "ACTION_EAT";
        listePercepts[0] = "PERCEPT_RESSOURCE";
        _listeStringPerceptsVoulus = listePercepts;
        _stringAction = action;

    }
}
