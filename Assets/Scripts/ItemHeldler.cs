using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ItemHeldler : MonoBehaviour
{
    public Objet _heldObjet;


    void Start()
    {
        GameObject.Find("Inventory").GetComponent<TestInventory>().Add(_heldObjet);
    }
}
