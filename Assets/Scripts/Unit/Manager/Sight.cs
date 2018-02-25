using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Sight : MonoBehaviour
{
    public float _angle;
    public float _distance;
    public SphereCollider _sphereCollider;
    public Brain _brain;
    [Header("Object in Sight")]
    [SerializeField]
    public List<GameObject> _listOfCollision;


    // Use this for initialization
    void Start()
    {
        _sphereCollider.radius = _distance;
    }

    void Update()
    {

        for (int i = 0; i < 360; i ++)
        {
            float h = GetComponent<UnitManager>()._stats._heading * Mathf.Deg2Rad;
            float I = i * Mathf.Deg2Rad;
            Vector3 A = new Vector3(Mathf.Cos(h), 0, Mathf.Sin(h)).normalized * 2;
            Vector3 B = new Vector3(Mathf.Cos(I), 0, Mathf.Sin(I)).normalized * 2;
            float angle = Vector3.Angle(A, B);
            if (angle <= _angle )
            {
                Debug.DrawLine(transform.position, transform.position + B, Color.blue);
            }
        }
            
    }

    /*
    void OnTriggerEnter(Collider other)
    {
        float h = 0;
        Vector3 A = new Vector3(Mathf.Cos(h), 0, Mathf.Sin(h)).normalized;
        Vector3 B = (other.transform.position - transform.position).normalized;
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
    */
    void OnTriggerStay(Collider other)
    {
      

        float h = GetComponent<UnitManager>()._stats._heading * Mathf.Deg2Rad;
        Vector3 A = new Vector3(Mathf.Cos(h), 0, Mathf.Sin(h)).normalized * _distance;
        Vector3 B = (other.transform.position - transform.position).normalized * _distance;

        float angle = Vector3.Angle(A, B);
        if (angle <= _angle && !_listOfCollision.Contains(other.gameObject))
        {
            
            _listOfCollision.Add(other.gameObject);
        }
        else if (angle > _angle && _listOfCollision.Contains(other.gameObject))
        {
            _listOfCollision.Remove(other.gameObject);
        }

        if (_listOfCollision.Contains(other.gameObject)) { Debug.DrawLine(transform.position, other.transform.position, Color.green); }
        else { Debug.DrawLine(transform.position, other.transform.position, Color.yellow); }
    }


}
