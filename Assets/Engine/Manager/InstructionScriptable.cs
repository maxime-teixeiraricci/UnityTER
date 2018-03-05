using System.Collections;
using System.Collections.Generic;
using UnityEngine;


[CreateAssetMenu(menuName = "Instruction")]
public class InstructionScriptable : ScriptableObject
{

    public string[] _listeStringPerceptsVoulus;
    public string _stringAction;

   public bool verify(Percept[] listePerceptsUtilisables)
    {
        bool verifie = true;
        foreach (string s in _listeStringPerceptsVoulus)
        {
            foreach (Percept p2 in listePerceptsUtilisables)
            {
                if (s.Equals(p2._perceptName))
                {
                    verifie = p2._value;
                }
            }

            if (!verifie)
            {
                break;
            }
        }
        if (verifie)
        {
            return true;
        }


        return false;
    }
}
