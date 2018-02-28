using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ActionSimplePick : Action
{
    public GameObject _target;

    public override void Do()
    {
        Objet obj = _target.GetComponent<Objet>();
        Inventory unitInventory = GetComponent<UnitManager>().GetComponent<Inventory>();
        unitInventory.add(obj);
        obj.getPicked();
    }

}