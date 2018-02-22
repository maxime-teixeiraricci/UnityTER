using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ActionTake : Action
{
    public ActionTake(Brain brain)
    {
        _brain = brain;
    }

    override public void Do()
    {
        //_brain.take();
    }
}
