﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Inventory : MonoBehaviour{

    [SerializeField]
    private List<ItemFood> _ressource = new List<ItemFood>();
    [SerializeField]
    private int _maxSize;
    [SerializeField]
    private int _actualSize;

    public bool add(ItemBehavior i)
    {
        if (_actualSize < _maxSize && i.getSize() <= (_maxSize - _actualSize))
        {
            ItemFood itemTake = new Item(i);
            _objets.Add(itemTake);
            _actualSize += i.getSize();
            return true;
        }
        else return false;
    }

    public Item pop(ItemFood i)
    {
        if (_objets.Contains(i))
        {
            _objets.Remove(i);
            _actualSize -= i.getSize();
            return i;
        }
        else return null;
    }

    public Item popLast()
    {
        if (_actualSize > 0)
        {
            ItemFood i = _objets[_actualSize - 1];
            _objets.Remove(i);
            _actualSize -= i.getSize();
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
