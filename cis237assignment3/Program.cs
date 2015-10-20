/*  Assignment: cis237assigment3
    File: Program.cs
    Author: Benjamin M. Campbell
 */

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cis237assignment3
{
    class Program
    {
        static void Main(string[] args)
        {
            DroidCollector droidCollector = new DroidCollector();
            UserInterface UI = new UserInterface(droidCollector);
            int userInput;

            do
            {   //Menu loop
                userInput = UI.ShowMenu();

                switch (userInput)
                {
                    case 1:
                        UI.PrintDroidList();
                        break;
                    case 2:
                        UI.AddDroid();
;                       break;
                    default:
                        break;
                }

            } while (userInput != 3);

        }
    }
}
