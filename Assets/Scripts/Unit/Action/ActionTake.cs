using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ActionTake : Action
{
    ItemBehavior target;

    public ActionTake(Brain brain)
    {
        _brain = brain;
    }

    public void setTarget(ItemBehavior newTarget)
    {
        target = newTarget;
    }

    override public void Do()
    {
        //_brain.take();
        Brain brain = _brain;
        MethodsPicker method = (MethodsPicker)_brain._methods;
        method.take(target);
    }
}
