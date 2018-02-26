using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Instruction : MonoBehaviour {

    [SerializeField]
    PerceptStructure[] _listePerceptsVoulus;
    [SerializeField]
    Action _action;

    public bool verify()
    {
        PerceptStructure[] listePerceptsUtilisables = GetComponent<UnitManager>().GetComponent<PerceptManager>()._percepts;
        bool verifie = true;
        foreach(PerceptStructure p in _listePerceptsVoulus)
        {
            foreach(PerceptStructure p2 in listePerceptsUtilisables)
            {
                if(p._name.Equals(p2._name))
                {
                    verifie = p2._percept._value;
                }
            }

            if (!verifie)
            {
                break;
            }
        }
        if (verifie)
        {
            _action.Do();
            return true;
        }


        return false;
    }
}
