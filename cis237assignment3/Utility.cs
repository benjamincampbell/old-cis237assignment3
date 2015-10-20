/*  Assignment: cis237assigment3
    File: Utility.cs
    Author: Benjamin M. Campbell
 */

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cis237assignment3
{
    class Utility : Droid
    {
        private bool toolbox;
        private bool computerConnection;
        private bool arm;

        public bool Toolbox
        {
            get { return toolbox; }
            set { toolbox = value; }
        }

        public bool ComputerConnection
        {
            get { return computerConnection; }
            set { computerConnection = value; }
        }

        public bool Arm
        {
            get { return arm; }
            set { arm = value; }
        }

        public Utility(string Model, string Material, string Color, bool Toolbox, bool ComputerConnection, bool Arm)
            : base(Model, Material, Color)
        {
            this.CalculateBaseCost();
            this.toolbox = Toolbox;
            this.computerConnection = ComputerConnection;
            this.arm = Arm;
            this.BaseCost += 15000;
            this.CalculateTotalCost();
        }

        public override string ToString()
        {
            return base.ToString() + string.Format(" | Toolbox: {0} | Connection: {1} | Arm: {2}", this.toolbox, this.computerConnection, this.arm);
        }

        public override void CalculateTotalCost()
        {
            if (toolbox)
            {   //Add to TotalCost based on features added or not
                this.TotalCost += 1000;
            }

            if (computerConnection)
            {
                this.TotalCost += 2000;
            }

            if (arm)
            {
                this.TotalCost += 1000;
            }
                //Always add the base cost
            this.TotalCost += this.BaseCost;
        }
    }
}
