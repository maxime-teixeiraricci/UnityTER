using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[System.Serializable]
public struct ActionStructure
{
    public string _name;
    public Action _action;

    public void Do()
    {
        _action.Do();
    }
}