using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cis237assignment3
{
    class Protocol : Droid
    {
        private int numberLanguages;
        private const int COSTPERLANGUAGE = 1000;

        public Protocol(string Model, string Material, string Color, int NumberLanguages)
            : base(Model, Material, Color)
        {
            this.numberLanguages = NumberLanguages;
            this.BaseCost = 10000;
            this.CalculateTotalCost();
        }

        public override string ToString()
        {
            return base.ToString() + string.Format(" | Languages: {0}", this.numberLanguages);
        }

        public override void CalculateTotalCost()
        {
            double languagesCost = this.numberLanguages * COSTPERLANGUAGE;
            this.TotalCost = Convert.ToDecimal(this.BaseCost + languagesCost);
        }

        public override void CalculateBaseCost()
        {

        }
    }
}
