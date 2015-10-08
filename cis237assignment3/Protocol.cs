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
        private const int costPerLanguage = 1000;

        public Protocol(string ID, string Model, string Material, string Color, int NumberLanguages)
            : base(ID, Model, Material, Color)
        {
            this.numberLanguages = NumberLanguages;
            this.BaseCost = 10000;
        }

        public override string ToString()
        {
            return base.ToString() + string.Format(" | Languages: {0}", this.numberLanguages);
        }

        public override void CalculateTotalCost()
        {
            double languagesCost = this.numberLanguages * costPerLanguage;
        }

        public override double CalculateBaseCost()
        {
            return this.BaseCost;
        }
    }
}
