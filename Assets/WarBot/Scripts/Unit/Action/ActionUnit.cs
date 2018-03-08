using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ActionUnit : MonoBehaviour
{
    public delegate void Act();

    // Liste des déclarations des actions. (ACTION_...)

    public Dictionary<string, Act> _actions = new Dictionary<string, Act>();

    void Start()
    {
        _actions["ACTION_MOVE"] = delegate () { GetComponent<MovableCharacter>().Move(); };
        _actions["ACTION_RANDOM_MOVE"] = delegate () 
        {
            GetComponent<Stats>()._heading = Random.Range(0, 360);
            GetComponent<MovableCharacter>().Move();
        };
        _actions["ACTION_HEAL"] = delegate () { GetComponent<Inventory>().use(); };
        _actions["ACTION_IDLE"] = delegate () { };
    }
}
