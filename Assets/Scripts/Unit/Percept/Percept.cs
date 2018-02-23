using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class Percept : MonoBehaviour
{
    public string _perceptName;
    public bool _value;
    public GameObject _gameObject;

    public abstract void update();

}
