using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InstructionPickLight : Instruction
{

    public InstructionPickLight()
    {
        string[] listePercepts = new string[1];
        string action;
        action = "ACTION_PICK";
        listePercepts[0] = "PERCEPT_RESSOURCE";
        _listeStringPerceptsVoulus = listePercepts;
        _stringAction = action;

    }
}
