using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ActionIdle : Action
{
    public ActionIdle(UnitBrain brain)
    {
        _unitBrain = brain;
    }

    override public void Do()
    {
        _unitBrain.idle();
    }
}
