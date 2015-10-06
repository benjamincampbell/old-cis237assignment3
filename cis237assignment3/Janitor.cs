using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cis237assignment3
{
    class Janitor : Utility
    {
        private string trashCompactorString;
        private string vacuumString;

        private bool trashCompactor;
        private bool vacuum;

        public Janitor(string Model, string Material, string Color, bool Toolbox, bool ComputerConnection, bool Arm, bool TrashCompactor, bool Vacuum)
            : base(Model, Material, Color, Toolbox, ComputerConnection, Arm)
        {
            this.trashCompactor = TrashCompactor;
            this.vacuum = Vacuum;
        }

        public override string ToString()
        {
            return base.ToString() + string.Format(" | Trash Compactor: {0} | Vacuum: {1}");
        }

        protected void CheckBools()
        {
            base.CheckBools();
        }
    }
}
