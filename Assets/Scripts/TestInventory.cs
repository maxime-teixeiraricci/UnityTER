using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TestInventory : MonoBehaviour
{
    //public List<Objet> objets;
    [SerializeField]
    public Dictionary<Objet, int> dictObjet = new Dictionary<Objet, int>();
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

    public void Add(Objet o)
    {
        if (dictObjet.ContainsKey(o))
        {
            dictObjet[o]++;
            print("" + o + " : " + dictObjet[o]);
        }
        else
        {
            dictObjet[o] = 1;
            print("" + o + " : " + dictObjet[o]);
        }
    }
}
