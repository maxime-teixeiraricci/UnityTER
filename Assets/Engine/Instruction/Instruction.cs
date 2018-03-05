using System.Collections;
using System.Collections.Generic;
using System.Xml;
using UnityEngine;

public class Instruction : MonoBehaviour {
<<<<<<< HEAD:Assets/Scripts/Unit/Instruction/Instruction.cs

    [SerializeField]
=======
>>>>>>> 990aa4b3681819ca1016e9a42a7128761188ab8e:Assets/Engine/Instruction/Instruction.cs
    public string[] _listeStringPerceptsVoulus;
    public string _stringAction;

    
   public Instruction(string[] ins, string act)
    {
        _stringAction = act;
<<<<<<< HEAD:Assets/Scripts/Unit/Instruction/Instruction.cs
        for (int i = 0; i < ins.Length; i++)
        {
            _listeStringPerceptsVoulus[i] = ins[i];
        }

    }
   
=======
        _listeStringPerceptsVoulus = ins;
    }
>>>>>>> 990aa4b3681819ca1016e9a42a7128761188ab8e:Assets/Engine/Instruction/Instruction.cs

    public XmlNode xmlStructure()
    {
        XmlDocument l_doc = new XmlDocument();
        XmlNode l_whenNode = l_doc.CreateElement(this.name);

        XmlNode paramNode = l_doc.CreateElement("parameters");
        foreach (string c in _listeStringPerceptsVoulus)
        {
            XmlElement t = l_doc.CreateElement(c);
            paramNode.AppendChild(t);
        }
       

        l_whenNode.AppendChild(paramNode);

        XmlNode actNode = l_doc.CreateElement("actions");

        XmlElement a = l_doc.CreateElement(_stringAction);
        l_whenNode.AppendChild(actNode);

        return l_whenNode;
    }

    public bool verify()
    {
        Percept[] listePerceptsUtilisables = GetComponent<UnitManager>().GetComponent<PerceptManager>()._percepts;
        bool verifie = true;
        foreach(string s in _listeStringPerceptsVoulus)
        {
            foreach(Percept p2 in listePerceptsUtilisables)
            {
                if(s.Equals(p2._perceptName))
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

    public string[] getListeStringPerceptsVoulus()
    {
        return this._listeStringPerceptsVoulus;
    }

    public void setListeStringPerceptsVoulus(string[] percepts)
    {
        this._listeStringPerceptsVoulus = percepts;
    }

    public string getStringAction()
    {
        return this._stringAction;
    }

    public void setStringAction(string action)
    {
        this._stringAction = action;
    }
}
