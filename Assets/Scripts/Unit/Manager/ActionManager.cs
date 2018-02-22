using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class ActionManager : MonoBehaviour
{
    public Dictionary<string, Action> _actions = new Dictionary<string, Action>();
    private Brain _brain;

    
}
