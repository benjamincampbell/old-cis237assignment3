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
        private string id;

        public string Id
        {
            get { return id; }
            set { id = value; }
        }

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

        public Droid(string ID, string Model, string Material, string Color)
        {
            this.id = ID;
            this.model = Model;
            this.material = Material;
            this.color = Color;
        }

        public Droid()
        {

        }

        public override string ToString()
        {
            return string.Format("ID: {0} | {1} Droid | Material: {2} | Color: {3}", this.id, this.model, this.material, this.color);
        }

        public abstract double CalculateBaseCost();

        public abstract void CalculateTotalCost();

    }
}
