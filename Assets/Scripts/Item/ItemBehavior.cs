using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public abstract class ItemBehavior : MonoBehaviour{

    [SerializeField]
    private int _value;
    private Collider _collider;
    [SerializeField]
    private int _size;
    [SerializeField]
    private string _name;

    public string getName()
    {
        return _name;
    }

    public int getValue()
    {
        return _value;
    }

    public int getSize()
    {
        return _size;
    }

    public void getPicked()
    {
        Destroy(gameObject);
    }

}
