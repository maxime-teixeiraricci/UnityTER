using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UnitManager : MonoBehaviour
{
    
    public Brain brain;

	// Use this for initialization
	void Start ()
    {
		
	}
	
	// Update is called once per frame
	void Update ()
    {
		
	}

    void OnGUI()
    {
        Display(brain);
    }

    void Display(Brain brain)
    {
        GUILayout.Label("Value: ");
        GUILayout.BeginHorizontal();
        GUILayout.Space(20);
        GUILayout.BeginVertical();
        if (GUILayout.Button("Add child"))
        {
            print("");
        }
        GUILayout.EndVertical();
        GUILayout.EndHorizontal();
    }
}
