using System.Collections;
using System.Collections.Generic;
using System.Xml;
using UnityEngine;

public abstract class Instruction : MonoBehaviour {

    [SerializeField]
    public string[] _listeStringPerceptsVoulus;
    [SerializeField]
    public string _stringAction;

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
}
