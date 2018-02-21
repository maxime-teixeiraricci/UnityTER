using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SightManager : MonoBehaviour
{
    public float _angle;
    public float _distance;
    [SerializeField]
    public List<GameObject> _listOfCollision;
    public SphereCollider _sphereCollider;
    public UnitBrain _unitBrain;

	// Use this for initialization
	void Start ()
    {
        _sphereCollider.radius = _distance;
	}

    void OnTriggerEnter(Collider other)
    {
        print("A " + other);
        float h = Mathf.Deg2Rad * _unitBrain.heading;
        Vector3 A = new Vector3(Mathf.Sin(h), 0, Mathf.Cos(h)).normalized;
        Vector3 B = other.transform.position - transform.position;
        float angle = Vector3.Angle(A, B);

        Color colorDebug = Color.blue;
        if (angle <= _angle && !_listOfCollision.Contains(other.gameObject))
        {
            _listOfCollision.Add(other.gameObject);
            colorDebug = Color.red;
        }
        Debug.DrawLine(transform.position, other.transform.position, colorDebug);
    }

    void OnTriggerExit(Collider other)
    {
        
        if (_listOfCollision.Contains(other.gameObject))
        {
            _listOfCollision.Remove(other.gameObject);
        }
    }
}
