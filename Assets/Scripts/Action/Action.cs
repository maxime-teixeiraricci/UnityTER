using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[System.Serializable]
public abstract class Action : MonoBehaviour
{
    public string _actionName;
    public UnitBrain _unitBrain;

    abstract public void Do();
    
}
