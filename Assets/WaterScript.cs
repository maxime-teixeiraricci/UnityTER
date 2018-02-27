using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WaterScript : MonoBehaviour
{
    private Vector3 _initPosition;
    public float _amplitude;
    public float _speed;

    private float _random;


	// Use this for initialization
	void Start ()
    {
        _initPosition = transform.position;
        _random = Random.Range(0, 2 * Mathf.PI);
	}
	
	// Update is called once per frame
	void FixedUpdate ()
    {
        transform.position = _initPosition + new Vector3(0, Mathf.Cos(_random + Time.time * _speed) * _amplitude, 0);
        GetComponent<MeshRenderer>().materials[0].mainTextureOffset += new Vector2(Time.deltaTime * 0.02f, Time.deltaTime * 0.03f);
	}
}
