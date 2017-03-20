//Anthony Aernie
//CIS237 MW 6:00
//Mar 20, 2017
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cis237assignment4
{
    class Program
    {
        static void Main(string[] args)
        {
            //Create a new droid collection and set the size of it to 100.
            IDroidCollection droidCollection = new DroidCollection(100);
            //Create a user interface and pass the droidCollection into it as a dependency
            UserInterface userInterface = new UserInterface(droidCollection);
            //Display the main greeting for the program
            userInterface.DisplayGreeting();
            //Display the main menu for the program
            userInterface.DisplayMainMenu();
            //Get the choice that the user makes
            int choice = userInterface.GetMenuChoice();

            //*****************
            //Hard coded Droids
            //*****************
            //Todo, change to droid stack
            droidCollection.Add("Quadranium", "Protocol", "Gold", 10);
            droidCollection.Add("Vanadium", "Astromech", "Silver", true, true, false, true, 3);
            droidCollection.Add("Quadranium", "Utility", "Silver", false, false, true);
            droidCollection.Add("Carbonite", "Janitor", "Bronze", true, false, true, true, true);
            droidCollection.Add("Vanadium", "Janitor", "Silver", false, true, false, false, false);
            droidCollection.Add("Carbonite", "Protocol", "Bronze", 6);
            droidCollection.Add("Carbonite", "Utility", "Gold", true, true, true);
            droidCollection.Add("Quadranium", "Astromech", "Gold", false, false, false, false, 10);
            droidCollection.Add("Quadranium", "Janitor", "Gold", true, true, true, true, true);
            droidCollection.Add("Vanadium", "Protocol", "Silver", 13);
            droidCollection.Add("Carbonite", "Astromech", "Gold", false, true, false, true, 7);
            droidCollection.Add("Vanadium", "Utility", "Silver", true, false, true);


            //While the choice is not equal to 3, continue to do work with the program
            while (choice != 5)
            {
                //Test which choice was made
                switch (choice)
                {
                    //Choose to create a droid
                    case 1:
                        userInterface.CreateDroid();
                        break;

                    //Choose to Print the droid
                    case 2:
                        userInterface.PrintDroidList();
                        break;

                    //****************
                    //New Menu Options
                    //****************

                    //Choose to Categorize by Model
                    case 3:
                        droidCollection.CategorizeModels();
                        userInterface.Display("Categorized Successfully");
                        break;

                    //Choose to Sort total cost
                    case 4:                        
                        droidCollection.MergeSort();
                        userInterface.Display("Merge Sort Successful");
                        break;
                }
                //Re-display the menu, and re-prompt for the choice
                userInterface.DisplayMainMenu();
                choice = userInterface.GetMenuChoice();
            }
        }
    }
}
