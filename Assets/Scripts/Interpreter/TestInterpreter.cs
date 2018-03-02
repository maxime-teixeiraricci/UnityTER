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
           string teamName = "DoudouLaMalice";
           string unitName = "Light";
           XMLWarbotInterpreter interpreter = new XMLWarbotInterpreter();
           List<Instruction> behavior = new List<Instruction>();


            // Condition bag1 = new Condition("Empty", true);
            // Condition near1 = new Condition("NearEnemies", false);
            // Action idle1 = new Action("Idle");
            // Action walk1 = new Action("Walk");

            //Task i1 = new Task();
            //i1.addCondition(bag1);
            //i1.addAction(walk1);

            //behavior.Add(i1);
            //behavior.Add(idle1);


            interpreter.behaviorToXml(teamName, Constants.teamsDirectory, unitName, behavior);
                          System.Console.WriteLine("fini");
                          System.Console.ReadLine();
            // System.Console.WriteLine("fini");
           /* */


            // partie 2 , lecture du fichier

            /* */
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
