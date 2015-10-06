using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cis237assignment3
{
    class DroidCollector
    {
        Droid[] droidArray = new Droid[100];

        public DroidCollector()
        {

        }

        public string GetDroidList()
        {   //Returns a string list of all droids in the droidArray
            string droidList = "";

            foreach (Droid droid in droidArray)
            {
                droidList += droid.ToString() + Environment.NewLine;
            }

            return droidList;

        }

        public void addDroid(string Model, string Material, string Color, int NumberLanguages)
        {

        }

        public void addDroid(string Model, string Material, string Color, bool Toolbox, bool ComputerConnection, bool Arm)
        {

        }

        public void addDroid(string Model, string Material, string Color, bool Toolbox, bool ComputerConnection, bool Arm, bool TrashCompactor, bool Vacuum)
        {

        }

        public void addDroid(string Model, string Material, string Color, bool Toolbox, bool ComputerConnection, bool Arm, bool FireExtinguisher, int NumberShips)
        {

        }
    }
}
