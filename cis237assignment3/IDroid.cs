using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cis237assignment3
{
    interface IDroid
    {
        void CalculateTotalCost();

        decimal TotalCost { get; set; }
    }
}
