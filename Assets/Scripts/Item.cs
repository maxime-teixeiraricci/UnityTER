using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Item : MonoBehaviour{
    private int _value;
    private Collider _collider;
    private int _size;

    public int getSize()
    {
        return _size;
    }

    public void getPicked()
    {
        Destroy(gameObject);
    }
}
