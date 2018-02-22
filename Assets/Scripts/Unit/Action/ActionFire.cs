using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ActionFire : Action
{
    public ActionFire(UnitBrain brain)
    {
        _unitBrain = brain;
    }

    override public void Do()
    {
        _unitBrain.shoot();
    }
}
