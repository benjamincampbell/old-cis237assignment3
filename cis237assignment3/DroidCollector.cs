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
                droidListString += droid.ToString() + Environment.NewLine;
            }

            return droidListString;

        }

        public void addDroid(string ID, string Model, string Material, string Color, int NumberLanguages)
        {
            Protocol newDroid = new Protocol(ID, Model, Material, Color, NumberLanguages);
            droidList.Add(newDroid);
        }

        public void addDroid(string ID, string Model, string Material, string Color, bool Toolbox, bool ComputerConnection, bool Arm)
        {
            Utility newDroid = new Utility(ID, Model, Material, Color, Toolbox, ComputerConnection, Arm);
            droidList.Add(newDroid);

        }

        public void addDroid(string ID, string Model, string Material, string Color, bool Toolbox, bool ComputerConnection, bool Arm, bool TrashCompactor, bool Vacuum)
        {
            Janitor newDroid = new Janitor(ID, Model, Material, Color, Toolbox, ComputerConnection, Arm, TrashCompactor, Vacuum);
            droidList.Add(newDroid);

        }

        public void addDroid(string ID, string Model, string Material, string Color, bool Toolbox, bool ComputerConnection, bool Arm, bool FireExtinguisher, int NumberShips)
        {
            Astromech newDroid = new Astromech(ID, Model, Material, Color, Toolbox, ComputerConnection, Arm, FireExtinguisher, NumberShips);
            droidList.Add(newDroid);

        }
    }
}
