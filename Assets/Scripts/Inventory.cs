using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Inventory{

    private List<Item> _objets;
    private int _maxSize;
    private int _actualSize;

    public bool add(Item i)
    {
        if (_actualSize < _maxSize && i.getSize() <= (_maxSize - _actualSize))
        {
            _objets.Add(i); return true;
        }
        else return false;
    }

    public Item pop(Item i)
    {
        if (_objets.Contains(i))
        {
            _objets.Remove(i);
            return i;
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
