﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ActionSimplePick : Action
{
    public GameObject _target;

    public override void Do()
    {
        ItemBehavior item = _target.GetComponent<ItemBehavior>();
        Inventory unitInventory = GetComponent<UnitManager>().GetComponent<Inventory>();
        unitInventory.add(item);
        item.getPicked();
    }

}