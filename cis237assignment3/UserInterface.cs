﻿/*  Assignment: cis237assigment3
    File: UserInterface.cs
    Author: Benjamin M. Campbell
 */

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

        //Arrays containing the available options for models and materials
        string[] availableModels = { "PROTOCOL", "UTILITY", "JANITOR", "ASTROMECH" };
        string[] availableMaterials = { "ALUMINIUM", "TITANIUM", "AGRINIUM" };
        string[] availableColors = { "RED", "GREEN", "PURPLE", "GRAY" };

        public UserInterface(DroidCollector DroidCollector)
        {
            this.collector = DroidCollector;
        }

        public int ShowMenu()
        {   //Method to show menu, ask for the selection, and return it
            Console.WriteLine("Welcome to the Droid Management System, v. 0.1" + Environment.NewLine +
                   "Please choose a command:" + Environment.NewLine +
                   "1: Print Droid List" + Environment.NewLine +
                   "2: Add New Droid" + Environment.NewLine +
                   "3: Exit Program");
            return Int32.Parse(Console.ReadLine());
        }

        public void PrintDroidList()
        {   //Method to print the list of droids we get from the DroidCollector
            Console.WriteLine(collector.GetDroidList());
        }

        private string printStringArray(string[] array)
        {   //Method to quickly and cleanly print string arrays (used for printing available models and materials
            string result = "";
            foreach (string item in array)
            {
                result += string.Format("{0} ", item);
            }
            return result;
        }

        public void AddDroid()
        {
            Console.WriteLine("Enter model of new droid:" + Environment.NewLine +
                              "Available models: " + printStringArray(availableModels));
            string userModel = Console.ReadLine().Trim().ToUpper();
            while (!availableModels.Contains(userModel))
            {   //Check to make sure the chosen model is available
                Console.WriteLine("Model not available, please choose another.");
                userModel = Console.ReadLine().Trim().ToUpper();

            }

            Console.WriteLine("Enter Material: " + Environment.NewLine +
                              "Available materials: " + printStringArray(availableMaterials));
            string userMaterial = Console.ReadLine().Trim().ToUpper();
            while (!availableMaterials.Contains(userMaterial))
            {   //Make sure chosen material is available
                Console.WriteLine("Material not available, please enter different matieral.");
                userMaterial = Console.ReadLine().Trim().ToUpper();
            }

            Console.WriteLine("Enter Color: " + Environment.NewLine + 
                              "Available colors: " + printStringArray(availableColors));
            string userColor = Console.ReadLine().Trim().ToUpper();
            while (!availableColors.Contains(userColor))
            {   //Make sure chosen material is available
                Console.WriteLine("Material not available, please enter different matieral.");
                userColor = Console.ReadLine().Trim().ToUpper();
            }

            if (userModel == availableModels[0])
            {   //Protocol Droid
                Console.WriteLine("Enter number of languages: ");
                int userLanguages = Int32.Parse(Console.ReadLine().Trim());
                collector.addDroid(userModel, userMaterial, userColor, userLanguages);
            }
            else
            {   //Utility, Janitor, or Astromech droid
                Console.WriteLine("Toolbox? Y or N: ");
                bool userToolbox = sortBool(Console.ReadLine().Trim().ToUpper());
                Console.WriteLine("Computer Connection? Y or N: ");
                bool userCompConn = sortBool(Console.ReadLine().Trim().ToUpper());
                Console.WriteLine("Arm? Y or N: ");
                bool userArm = sortBool(Console.ReadLine().Trim().ToUpper());

                if (userModel == availableModels[1])
                {   //Utility Droid
                    collector.addDroid(userModel, userMaterial, userColor, userToolbox, userCompConn, userArm);
                }

                if (userModel == availableModels[2])
                {   //Janitor Droid
                    Console.WriteLine("Trash Compactor? Y or N: ");
                    bool userTrash = sortBool(Console.ReadLine().Trim().ToUpper());
                    Console.WriteLine("Vacuum? Y or N: ");
                    bool userVacuum = sortBool(Console.ReadLine().Trim().ToUpper());
                    collector.addDroid(userModel, userMaterial, userColor, userToolbox, userCompConn, userArm, userTrash, userVacuum);
                }

                if (userModel.ToUpper() == availableModels[3])
                {
                    Console.WriteLine("Fire Extringuisher? Y or N: ");
                    bool userFire = sortBool(Console.ReadLine().Trim().ToUpper());
                    Console.WriteLine("Enter number of ships: ");
                    int userShips = Int32.Parse(Console.ReadLine().Trim());
                    collector.addDroid(userModel, userMaterial, userColor, userToolbox, userCompConn, userArm, userFire, userShips);
                }
            }
        }

        private bool sortBool(string userInput)
        {   //This method takes user input Y or N and turns it into a boolean true or false that is returned
            string[] validInput = {"Y", "N"};

            while (!validInput.Contains(userInput))
            {
                Console.WriteLine("Please enter Y or N");
                userInput = Console.ReadLine().Trim().ToUpper();
            }

            if (userInput == "Y")
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
