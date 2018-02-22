using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ActionFire : Action
{
    public ActionFire(Brain brain)
    {
        _brain = brain;
    }

    override public void Do()
    {
        Brain brain = _brain;
        MethodsMovable method = (MethodsMovable)_brain._methods;
        method.shoot();
        //_brain.shoot();
    }
}
