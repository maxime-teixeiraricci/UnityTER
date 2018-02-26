using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ActionSimpleShoot : Action
{
    public GameObject _bullet;

    public override void Do()
    {
        GameObject bullet = Instantiate(_bullet, this.transform.position, Quaternion.identity);
        bullet.GetComponent<BulletScript>()._owner = gameObject;
        bullet.GetComponent<BulletScript>()._vect = transform.forward;
    }

}