using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PerceptFoodInventory : Percept {

    public Objet _objetFood;
    Objet _objetPercu = null;

    PerceptFoodInventory()
    {
        _perceptName = "PERCEPT_FOOD_INVENTORY";
        _value = false;
    }

    override public void update()
    {
        Inventory inventory = GetComponent<Brain>().GetComponent<Inventory>();
        if (inventory._objets.ContainsKey(_objetFood) && inventory._objets[_objetFood] != 0)
        {
            _value = true;
            _objetPercu = _objetFood;
        }
        else
        {
            _value = false;
            _objetPercu = null;
        }
    }

}
