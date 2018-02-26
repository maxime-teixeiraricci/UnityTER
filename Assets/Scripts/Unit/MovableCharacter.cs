using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovableCharacter : MonoBehaviour
{
    public float speed;
    public Vector3 vectMov;
    public bool _isblocked;
    public float _offset;
    	
	// Update is called once per frame
	void FixedUpdate () {

       
        

    }
    

    public void Move()
    {
        float h = GetComponent<UnitManager>()._stats._heading * Mathf.Deg2Rad;
        vectMov = new Vector3(Mathf.Cos(h), 0, Mathf.Sin(h));
        Vector3 nextposition = transform.position + vectMov.normalized * speed * Time.deltaTime;
        
        if (Physics.Raycast(nextposition + vectMov.normalized * _offset, Vector3.down, 2f))
        {
            _isblocked = false;
            transform.position = nextposition;
        }
        else { _isblocked = true; }
    }
}
