using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BulletScript : MonoBehaviour
{
    public float _lifeTime;
    public GameObject _owner;
    public Vector3 _vect;
    public float _speed;
    public int _damage;

	void Update ()
    {
        transform.position += _vect.normalized * Time.deltaTime * _speed;
        _lifeTime -= Time.deltaTime;
        if (_lifeTime < 0f)
        {
            Destroy(gameObject);
        }

    }

    void OnTriggerStay(Collider other)
    {
        print(""+ other.gameObject + " =? "+ gameObject);
        if (!other.isTrigger && other.GetComponent<Stats>() && other.gameObject != _owner.gameObject)
        {
            other.GetComponent<Stats>()._health -= _damage;
            _damage = 0;
            Destroy(gameObject);
        }
    }
}
