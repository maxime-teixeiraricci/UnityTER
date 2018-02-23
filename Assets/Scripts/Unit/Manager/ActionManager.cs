using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[System.Serializable]
public struct ActionManager
{
    public string _name;
    public Action _action;

    public void Do()
    {
        _action.Do();
    }
}