
using System.Collections.Generic;
using System.Reflection;
using UnityEngine;
using UnityTER.Interpreter;

//[assembly: AssemblyVersionAttribute("1.0")]
public class TestInterpreterSecond : MonoBehaviour
{
    
    public List<Instruction> _instruction = new List<Instruction>();
    public int i = 2;

    void Start()
    {
        string teamName = "TestInterpret";
        string unitName = "Light";


        XMLWarbotInterpreter interpreter = new XMLWarbotInterpreter();
        List<Instruction> behavior = new List<Instruction>();

        // INSTRUCTION DE EAT DES LIGHTS
        string[] percepts = new string[] { "PERCEPT_FOOD_INVENTORY", "PERCEPT_LIFE_NOT_MAX" };
        string action = "ACTION_EAT";


        Instruction i = new Instruction(percepts, action);
        behavior.Add(i);

        interpreter.behaviorToXml(teamName, Constants.teamsDirectory, unitName, behavior);
        System.Console.WriteLine("Ecriture fichier XML termine.");
        System.Console.ReadLine();

        /* */

        List<Instruction> behavior2 = new List<Instruction>();
        behavior2 = interpreter.xmlToUnitBehavior(teamName, Constants.teamsDirectory, unitName);
        _instruction = behavior2;
        System.Console.WriteLine("count : " + behavior2.Count);
        for (int cpt = 0; cpt < behavior2.Count; cpt++)
        {
            System.Console.WriteLine(behavior2[cpt].getStringAction());
            foreach (string s in behavior2[cpt]._listeStringPerceptsVoulus)
                System.Console.WriteLine(s);
        }

        System.Console.WriteLine("Construction du comportement depuis fichier XML termine.");
        System.Console.ReadLine();

        /* */


    }

    void Update()
    {
        foreach (Instruction i in _instruction)
        {
            print(i);
        }
    }

}
