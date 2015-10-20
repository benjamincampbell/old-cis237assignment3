/*  Assignment: cis237assigment3
    File: DroidCollector.cs
    Author: Benjamin M. Campbell
 */

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cis237assignment3
{
    class DroidCollector
    {
        List<Droid> droidList = new List<Droid>();

        public DroidCollector()
        {

        }

        public string GetDroidList()
        {   //Returns a string list of all droids in the droidArray
            string droidListString = "";

            foreach (var droid in droidList)
            {
                droidListString += droid.ToString() + " | Price: " + droid.TotalCost + Environment.NewLine;
            }

            return droidListString;

        }


        //These are the overloaded methods that determine what kind of droid we are making based on the number
        //of arguments passed in from the UserInterface
        public void addDroid(string Model, string Material, string Color, int NumberLanguages)
        {
            Protocol newDroid = new Protocol(Model, Material, Color, NumberLanguages);
            droidList.Add(newDroid);
        }

        public void addDroid(string Model, string Material, string Color, bool Toolbox, bool ComputerConnection, bool Arm)
        {
            Utility newDroid = new Utility(Model, Material, Color, Toolbox, ComputerConnection, Arm);
            droidList.Add(newDroid);

        }

        public void addDroid(string Model, string Material, string Color, bool Toolbox, bool ComputerConnection, bool Arm, bool TrashCompactor, bool Vacuum)
        {
            Janitor newDroid = new Janitor(Model, Material, Color, Toolbox, ComputerConnection, Arm, TrashCompactor, Vacuum);
            droidList.Add(newDroid);

        }

        public void addDroid(string Model, string Material, string Color, bool Toolbox, bool ComputerConnection, bool Arm, bool FireExtinguisher, int NumberShips)
        {
            Astromech newDroid = new Astromech(Model, Material, Color, Toolbox, ComputerConnection, Arm, FireExtinguisher, NumberShips);
            droidList.Add(newDroid);

        }
    }
}
