using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PerceptManager : MonoBehaviour
    {
    public Percept[] _percepts;


    void Update()
    {
        foreach (Percept p in _percepts)
        {
            p.update();
        }
    }

   
}
    
