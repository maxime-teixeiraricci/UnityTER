using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ColorChange : MonoBehaviour
{
    public Material[] _materials;
	// Use this for initialization
	void Start ()
    {
		foreach (Material mat in _materials)
        {
            mat.color = GameObject.Find("GameManager").GetComponent<TeamManager>()._teams[GetComponent<Stats>()._teamIndex]._color;
        }
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
