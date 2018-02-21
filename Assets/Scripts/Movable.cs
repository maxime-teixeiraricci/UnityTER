using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class Movable : MoveActions, MoveMethods
{
    private double _speed;

    public abstract void move();

    public double getSpeed()
    {
        return _speed;
    }

    public abstract bool isBlocked();

}
