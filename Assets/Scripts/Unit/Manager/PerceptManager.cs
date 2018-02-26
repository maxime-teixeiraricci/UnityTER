using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PerceptManager : MonoBehaviour
    {
    public Percept[] _percepts;


    void Update()
    {
        //_percepts[0].Do();
    }

    public PerceptStructure findPercept(string percepts)
    {
        foreach (PerceptStructure ps in _percepts)
        {
            if (ps._name.Equals(percepts)) { return ps; }
        }
        return null;
    }
}
    
