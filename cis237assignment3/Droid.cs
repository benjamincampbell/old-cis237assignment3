using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cis237assignment3
{
    abstract class Droid : IDroid
    {
        private string material;
        private string model;
        private string color;
        private double baseCost;
        private decimal totalCost;

        public double BaseCost
        {
            get { return baseCost; }
            set { baseCost = value; }
        }
        public string Color
        {
            get { return color; }
            set { color = value; }
        }
        public string Model
        {
            get { return model; }
            set { model = value; }
        }
        public string Material
        {
            get { return material; }
            set { material = value; }
        }
        public decimal TotalCost
        {
            get { return totalCost; }
            set { totalCost = value; }
        }

        public Droid(string Model, string Material, string Color)
        {

        }

        public Droid()
        {

        }

        public override string ToString()
        {
            return string.Format("{0} Droid | Material: {1} | Color: {2}", this.model, this.material, this.color);
        }

        public abstract double CalculateBaseCost();

        public abstract void CalculateTotalCost();
    }
}
