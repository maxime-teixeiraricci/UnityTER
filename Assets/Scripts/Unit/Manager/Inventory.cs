using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Inventory : MonoBehaviour{

    [SerializeField]
    private Dictionary<Objet,int> _objets = new Dictionary<Objet, int>();
    [SerializeField]
    private int _maxSize;
    [SerializeField]
    private int _actualSize;

    public bool add(Objet obj)
    {
        if (_actualSize < _maxSize && obj._size <= (_maxSize - _actualSize))
        {
            _objets.Add(obj,1);
            _actualSize += obj._size;
            return true;
        }
        else return false;
    }

    public Objet pop(Objet obj)
    {
        if (_objets.ContainsKey(obj) && _objets[obj] > 0)
        {
            _objets[obj] -= 1;
            _actualSize -= obj._size;
            return obj;
        }
        else return null;
    }

    public bool isFull()
    {
        return _actualSize == _maxSize;
    }

    public bool isEmpty()
    {
        return _actualSize == 0;
    }
}
