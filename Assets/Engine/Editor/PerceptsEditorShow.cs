//c# Example (LookAtPointEditor.cs)
using UnityEngine;
using UnityEditor;


[CustomEditor(typeof(PerceptUnit))]
[CanEditMultipleObjects]

public class LookAtPointEditor : Editor
{
    PerceptUnit myTarget;

    void OnEnable()
    {
        myTarget = (PerceptUnit)target;
    }

    public override void OnInspectorGUI()
    {
        PerceptUnit myTarget = (PerceptUnit)target;
        GUILayout.Label("Percepts :", EditorStyles.boldLabel);
        foreach (string key in myTarget._percepts.Keys)
        {
            string b = (myTarget._percepts[key]()) ? "O" : "X";
            EditorGUILayout.LabelField("[" + b + "] " + key );
        }
    }
}