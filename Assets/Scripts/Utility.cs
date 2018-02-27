using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Utility{

	static public int getAngle(GameObject obj)
    {
        return 0;
    }

    static public Vector3 vectorFromAngle(float angle)
    {
        float A = (360 - angle) * Mathf.Deg2Rad;
        return new Vector3(Mathf.Cos(A), 0, Mathf.Sin(A)).normalized;
    }
}
