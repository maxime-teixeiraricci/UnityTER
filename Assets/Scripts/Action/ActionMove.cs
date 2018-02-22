using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ActionMove : Action
{
    public ActionMove(UnitBrain brain)
    {
        _unitBrain = brain;
    }

    override public void Do()
    {
        _unitBrain.move();
    }
}
