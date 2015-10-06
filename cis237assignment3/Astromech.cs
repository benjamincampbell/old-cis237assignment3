using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cis237assignment3
{
    class Astromech : Utility
    {
        private string fireExtinguisherString;
        private string numberShipsString;

        public Astromech(string Model, string Material, string Color, bool Toolbox, bool ComputerConnection, bool Arm, bool FireExtinguisher, int NumberShips)
            : base(Model, Material, Color, Toolbox, ComputerConnection, Arm)
        {

        }
    }
}
