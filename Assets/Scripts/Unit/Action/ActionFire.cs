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

        //_brain.shoot();
    }
}
