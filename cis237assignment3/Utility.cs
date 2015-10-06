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

        private string toolboxString;
        private string connectionString;
        private string armString;

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

        }

        public override string ToString()
        {
            CheckBools();
            return base.ToString() + string.Format(" | Toolbox: {0} | Connection: {1} | Arm: {2}", this.toolboxString, this.connectionString, this.armString);
        }

        protected void CheckBools()
        {   //This method just turns the Trues and Falses of the bool variables to Yeses and Nos for the purpose of the ToString method
            if (this.toolbox)
            {
                toolboxString = "Yes";
            }
            else
            {
                toolboxString = "No";
            }

            if (this.computerConnection)
            {
                connectionString = "Yes";
            }
            else
            {
                connectionString = "No";
            }

            if (this.arm)
            {
                armString = "Yes";
            }
            else
            {
                armString = "No";
            }
        }

        public override double CalculateBaseCost()
        {
            return this.BaseCost;
        }

        public override void CalculateTotalCost()
        {
            throw new NotImplementedException();
        }
    }
}
