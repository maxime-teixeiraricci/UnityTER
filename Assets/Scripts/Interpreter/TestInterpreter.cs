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

            string[] conditions  = new string[3];
            conditions[0] = "NearEnnemy";
            conditions[1] = "NearBase";
            conditions[2] = "NotEmpty";

            string action = "ACTION_FIRE";

            Instruction i = new Instruction(conditions,action);

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
