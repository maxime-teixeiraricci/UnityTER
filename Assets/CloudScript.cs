using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CloudScript : MonoBehaviour
{
    public Vector3 _vectMove;
    public float _speed;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update ()
    {
        transform.position += _vectMove * Time.deltaTime * _speed;
        if (transform.position.x <= -30)
        {
            transform.position = new Vector3(Random.Range(30f, 45f), 22, Random.Range(-5f, 35f));
        }
	}
}
