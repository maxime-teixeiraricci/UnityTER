using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PerceptManager : MonoBehaviour {

    public Dictionary<string, Percept> _percepts = new Dictionary<string, Percept>();
    private Brain _brain;
}
