using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[System.Serializable]
public class PerceptStructure
{
    private Brain _brain;
    public string _name;
    public Percept _percept;

    public void Do()
    {
        _percept.update();
    }
}
