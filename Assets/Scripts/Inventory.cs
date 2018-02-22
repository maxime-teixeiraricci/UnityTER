using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Inventory : MonoBehaviour{

    [SerializeField]
    private List<Item> _objets = new List<Item>();
    [SerializeField]
    private int _maxSize;
    [SerializeField]
    private int _actualSize;

    public bool add(ItemBehavior i)
    {
        print("CACA");
        print(i.getName());
        if (_actualSize < _maxSize && i.getSize() <= (_maxSize - _actualSize))
        {
            Item itemTake = new Item(i);
            _objets.Add(itemTake);
            print(_objets[0].getValue());
            _actualSize += i.getSize();
            return true;
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
