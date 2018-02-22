using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[System.Serializable]
public abstract class Action
{
    public Brain _brain;
    abstract public void Do();
    
}
