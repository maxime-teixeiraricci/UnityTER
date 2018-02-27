using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FollowCamera : MonoBehaviour
{
    private Vector3 currentTarget;
    public float _speed;
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void FixedUpdate ()
    {
        Vector3 res = Vector3.zero;
        GameObject[] units = GameObject.FindGameObjectsWithTag("Unit");

        foreach (GameObject go in units)
        {
            res += go.transform.position;
        }
        res *= 1f / (units.Length + 1);
        currentTarget += (res - currentTarget) * Time.deltaTime * _speed;
        transform.LookAt(currentTarget);
	}
}
