using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ActionIdle : Action
{
    public ActionIdle(Brain brain)
    {
        _brain = brain;
    }

    override public void Do()
    {
        //_brain.idle();
        Brain brain = _brain;
        MethodsIdler method = (MethodsIdler)_brain._methods;
        method.idle();
    }
}
