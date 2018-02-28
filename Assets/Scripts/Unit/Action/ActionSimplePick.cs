using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ActionSimplePick : Action
{
    public GameObject _target;

    public override void Do()
    {
        Objet obj = GetComponent<PerceptRessource>()._gameObject.GetComponent<ItemHeldler>()._heldObjet;
        Inventory unitInventory = GetComponent<UnitManager>().GetComponent<Inventory>();
        unitInventory.add(obj);
        Destroy(GetComponent<PerceptRessource>()._gameObject);
    }

}