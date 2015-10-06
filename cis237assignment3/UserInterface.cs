using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cis237assignment3
{
    class UserInterface
    {
        private DroidCollector collector;

        public UserInterface(DroidCollector DroidCollector)
        {
            this.collector = DroidCollector;
        }

        public int ShowMenu()
        {
            Console.WriteLine("Welcome to the Droid Management System, v. 0.1" + Environment.NewLine +
                   "Please choose a command:" + Environment.NewLine +
                   "1: Print Droid List" + Environment.NewLine +
                   "2: Add New Droid" + Environment.NewLine + 
                   "3: Exit Program");
            return Int32.Parse(Console.ReadLine());
        }

        public void PrintDroidList()
        {
            Console.WriteLine(collector.GetDroidList());
        }

        public void GetDroidInfo()
        {
            Console.WriteLine("Model: ");
        }
    }
}
