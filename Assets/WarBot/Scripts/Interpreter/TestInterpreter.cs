using System.Collections.Generic;
using System.Reflection;
using UnityEngine;

[assembly: AssemblyVersionAttribute("1.0")]
namespace UnityTER.Interpreter
{ 
    class TestInterpreter : MonoBehaviour
    {
        static void Main(string[] args) {
           string teamName = "TestInterpret";
           string unitName = "Light";


           XMLWarbotInterpreter interpreter = new XMLWarbotInterpreter();
           List<Instruction> behavior = new List<Instruction>();

<<<<<<< HEAD:Assets/Scripts/Interpreter/TestInterpreter.cs
            string[] conditions  = new string[3];
            conditions[0] = "NearEnnemy";
            conditions[1] = "NearBase";
            conditions[2] = "NotEmpty";

            string action = "ACTION_FIRE";

            Instruction i = new Instruction(conditions,action);

=======

            // INSTRUCTION DE EAT DES LIGHTS
            string[] percepts = new string[] { "PERCEPT_FOOD_INVENTORY", "PERCEPT_LIFE_NOT_MAX" };
            string action = "ACTION_EAT";


            Instruction i = new Instruction(percepts, action);
>>>>>>> 990aa4b3681819ca1016e9a42a7128761188ab8e:Assets/WarBot/Scripts/Interpreter/TestInterpreter.cs
            behavior.Add(i);

            interpreter.behaviorToXml(teamName, Constants.teamsDirectory, unitName, behavior);
            System.Console.WriteLine("Ecriture fichier XML termine.");
            System.Console.ReadLine();

            /* */

            List<Instruction> behavior2 = new List<Instruction>();
            behavior2 = interpreter.xmlToUnitBehavior(teamName, Constants.teamsDirectory,unitName);
            for (int cpt = 0; cpt < behavior2.Count; cpt++)
            {
                System.Console.WriteLine(behavior2[cpt]._stringAction);
                foreach (string s in behavior2[cpt]._listeStringPerceptsVoulus)
                    System.Console.WriteLine(s);
            }

            System.Console.WriteLine("Construction du comportement depuis fichier XML termine.");
            System.Console.ReadLine();

            /* */


        }

        void Update()
        {

        }

    }


}
