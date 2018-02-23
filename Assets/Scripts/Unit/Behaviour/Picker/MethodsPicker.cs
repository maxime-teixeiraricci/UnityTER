using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MethodsPicker : Methods, PickerActions
{

    public void take(ItemBehavior target)
    {
        Inventory _inventory = GetComponent<Inventory>();
        if (!_inventory.isFull())
        {
            if (_inventory.add(target))
            {
                target.getPicked();

                target = null;
            }
        }
    }
}
