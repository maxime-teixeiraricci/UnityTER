using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RessourceColorScript : MonoBehaviour
{
    public MeshRenderer[] _mr;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update ()
    {
        float r = Mathf.Cos(5 * 0.5f * Time.time) * 0.5f + 0.5f;
        float g = Mathf.Cos(-0.25f * Time.time) * 0.5f + 0.5f;
        float b = Mathf.Sin(0.15f* Time.time) * 0.5f + 0.5f;
        
        foreach(MeshRenderer mr in _mr)
        {
            mr.material.color = new Color(r, g, b, mr.material.color.a);
        }
	}
}
