using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UnitBrain : Movable, Alive
{
    private int _currentHealth;
    private int _maxHealth;

    private double _speed;

    public int getHealth()
    {
        return _currentHealth;
    }

    public int getMaxHealth()
    {
        return _maxHealth;
    }

    public double getSpeed()
    {
        return _speed;
    }

    public bool isBlocked()
    {
        throw new System.NotImplementedException();
    }

    public void move()
    {
        throw new System.NotImplementedException();
    }

}
