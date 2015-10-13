using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cis237assignment3
{
    class Janitor : Utility
    {
        private bool trashCompactor;
        private bool vacuum;

        public Janitor(string ID, string Model, string Material, string Color, bool Toolbox, bool ComputerConnection, bool Arm, bool TrashCompactor, bool Vacuum)
            : base(ID, Model, Material, Color, Toolbox, ComputerConnection, Arm)
        {
            this.trashCompactor = TrashCompactor;
            this.vacuum = Vacuum;
            this.BaseCost = 5000;
        }

        public override string ToString()
        {
            return base.ToString() + string.Format(" | Trash Compactor: {0} | Vacuum: {1}", this.trashCompactor, this.vacuum);
        }

        public override void CalculateTotalCost()
        {
            base.CalculateTotalCost();

            if (trashCompactor)
            {
                this.TotalCost += 3000;
            }

            if (vacuum)
            {
                this.TotalCost += 2000;
            }
        }
    }
}
