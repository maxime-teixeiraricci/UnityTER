using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ActionTake : Action
{
    public ActionTake(UnitBrain brain)
    {
        _unitBrain = brain;
    }

    override public void Do()
    {
        _unitBrain.take();
    }
}
