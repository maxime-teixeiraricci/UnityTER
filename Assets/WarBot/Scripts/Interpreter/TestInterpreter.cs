using System.Collections.Generic;
using System.Reflection;
using UnityEngine;
using WarBotEngine.Editeur;

[assembly: AssemblyVersionAttribute("1.0")]
namespace Assets.Scripts.Editeur.Interpreter
{
    class TestInterpreter : MonoBehaviour
    {
        static void Main(string[] args) {
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
                          System.Console.WriteLine("fini");
                          System.Console.ReadLine();
            // System.Console.WriteLine("fini");
           /* */


            // partie 2 , lecture du fichier

            /* 
              Dictionary<string, List<Instruction>> behavior2 = new Dictionary<string, List<Instruction>>();
              behavior2 = interpreter.xmlToBehavior(teamName, Constants.teamsDirectory);
              for (int cpt = 0; cpt < behavior2["WarExplorer"].Count; cpt++)
              {
                  System.Console.WriteLine(behavior2["WarExplorer"][cpt].ToString());
              }
            System.Console.WriteLine("fini");
            System.Console.ReadLine();
            /* */


        }

        void Update()
        {

        }

    }


}
