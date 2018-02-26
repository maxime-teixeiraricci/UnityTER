using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InstructionMoveLight : Instruction
{
    public InstructionMoveLight()
    {
        string[] listePercepts = new string[0];
        string action;
        action = "ACTION_MOVE";

    _listeStringPerceptsVoulus = listePercepts;
    _stringAction = action;
        
    }
    
}
