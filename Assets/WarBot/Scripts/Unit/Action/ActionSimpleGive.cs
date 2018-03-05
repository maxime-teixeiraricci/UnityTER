using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ActionSimpleGive : Action
{
    public Objet _item;
    public GameObject _target;

    public override void Do()
    {
        _target = GetComponent<PerceptBaseNear>()._gameObject;
        if (GetComponent<Inventory>()._objets.ContainsKey(_item) && GetComponent<Inventory>()._objets[_item] != 0 && _target.GetComponent<Inventory>())
        {
            _target.GetComponent<Inventory>().add(_item);
            print("Base ressource : " + _target.GetComponent<Inventory>()._objets[_item]);
            GetComponent<Inventory>().pop(_item);
        }
    }

}