using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Inventory : MonoBehaviour{

    [SerializeField]
    public Dictionary<Objet,int> _objets = new Dictionary<Objet, int>();
    [SerializeField]
    public int _maxSize;
    [SerializeField]
    public int _actualSize;

    public bool add(Objet obj)
    {
        if (_actualSize < _maxSize && obj._size <= (_maxSize - _actualSize))
        {
            if (_objets.ContainsKey(obj)) { _objets[obj] += 10; }
            else { _objets.Add(obj, 10); }
            _actualSize += obj._size;
            return true;
        }
        else return false;
    }

    public bool pop(Objet obj)
    {
        if (_objets.ContainsKey(obj) && _objets[obj] > 0)
        {
            _objets[obj] -= 1;
            _actualSize -= obj._size;
            return true;
        }
        else return false;
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
