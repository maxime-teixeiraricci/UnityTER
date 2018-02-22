using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class MethodsAgressive : Methods, AgressiveActions
{
    public void fire()
    {

        GameObject bullet = Instantiate(_bullet, transform.position, Quaternion.identity);
        float h = Mathf.Deg2Rad * heading;
        bullet.GetComponent<BulletScript>().vect = new Vector3(Mathf.Sin(h), 0, Mathf.Cos(h)).normalized;

    }

    public void move()
    {
        throw new System.NotImplementedException();
    }

    public void reloadWeapon()
    {
        throw new System.NotImplementedException();
    }

}