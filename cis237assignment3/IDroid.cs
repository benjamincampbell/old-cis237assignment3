/*  Assignment: cis237assigment3
    File: IDroid.cs
    Author: Benjamin M. Campbell
 */

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

        double TotalCost { get; set; }
    }
}
