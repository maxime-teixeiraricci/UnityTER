using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TestSight : MonoBehaviour {

    public float testvalue;
    void Update()
    {
        float revealOffset = (float)(testvalue % 100) / 100;

        gameObject.GetComponent<MeshRenderer>().material.SetFloat("_Cutoff", revealOffset);
    }
}
