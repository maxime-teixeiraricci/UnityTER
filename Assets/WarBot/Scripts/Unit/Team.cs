using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Team : MonoBehaviour
{
    public Color _color;
    public MeshRenderer[] _meshRenderer;

    public bool equals(Team other)
    {
        return _color.Equals(other._color);
    }

    void Start()
    {
        foreach (MeshRenderer m in _meshRenderer)
        {
            foreach (Material mat in m.materials)
            {
                mat.color = _color;
            }
        }
    }

}
