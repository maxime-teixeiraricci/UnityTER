using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ActionSimpleHeal : Action {

    public override void Do()
    {
        Inventory unitInventory = GetComponent<UnitManager>().GetComponent<Inventory>();
        Stats unitStat = GetComponent<UnitManager>().GetComponent<Stats>();
        Item item = unitInventory.popLast();
        unitStat._health += item.getValue();
    }
}
