using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ActionSimpleHeal : Action
{
    public Objet _healingObject;
    public override void Do()
    {
        Inventory unitInventory = GetComponent<UnitManager>().GetComponent<Inventory>();
        Stats unitStat = GetComponent<UnitManager>().GetComponent<Stats>();
        if (unitInventory.pop(_healingObject))
        {
            unitStat._health += _healingObject._value;
            unitStat._health = Mathf.Min(unitStat._health, unitStat._maxHealth);
        }
    }
}
