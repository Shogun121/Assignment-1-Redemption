using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DynastyWarriorsApp
{
  /**
   * class designed to handle UI operations of the program.
   * */

    class UserInterface
    {
        //class instantiations
        RosterCollection rosterColl= new RosterCollection();

        //backing fields
        bool firstTimeMain = true;  //variable used to  prevent the entire method from printintg
                                    //on cotinual calls.
        string Input="";

        public void MainMenu()
        {   //method used to print the main menu
            
            if(firstTimeMain==true)
            {
                Console.WriteLine("Welcome to the Dynasty Warriors 8 database!");
            }

            //The lines that will print everytime the method is called.
            Console.WriteLine("------------------------------------------------------------------");
            Console.WriteLine("This is the main menu.");
            Console.WriteLine("------------------------------------------------------------------");
            Console.WriteLine("1. Print/Search");
            Console.WriteLine("2. Add To Master Array");
            Console.WriteLine("3. Write to File");
            Console.WriteLine("4. Read to File");
            Console.WriteLine("5. Sort");
            Console.WriteLine("6. Battles");
            Console.WriteLine("7. Exit");
            Console.WriteLine();

            //set firstTime to false now that the menu has been displayed on bootup.
            firstTimeMain = false;
        }
        public void PrintSearchMenu()
        {   //method used to print the search/print menu
            Console.Clear();
            Console.WriteLine("------------------------------------------------------------------");
            Console.WriteLine("This is the Print/Search Menu.");
            Console.WriteLine("------------------------------------------------------------------");
            Console.WriteLine("1. Print Complete Array.");
            Console.WriteLine("2. Print Full Names.");
            Console.WriteLine("3. Print a list of all the Family Names.");
            Console.WriteLine("4. Print the roster by Family Name.");
            Console.WriteLine("5. Print a list of all the factions.");
            Console.WriteLine("6. Print the roster by faction.");
            Console.WriteLine("7. Return to Main.");
            Console.WriteLine();
        }
        public void SortMenu()
        {   //method used to print the Sort menu
            Console.Clear();
            Console.WriteLine("------------------------------------------------------------------");
            Console.WriteLine("This is the Sort Menu.");
            Console.WriteLine("------------------------------------------------------------------");
            Console.WriteLine("1. Sort A-Z alphabetical.");
            Console.WriteLine("2. Sort by Family Name A-Z.");
            Console.WriteLine("3. Sort by Faction A-Z.");
            Console.WriteLine("4. Return to Main.");
            Console.WriteLine();
        }
        public void BattlesMenu()
        {   //method used to print the battles menu
            Console.Clear();
            Console.WriteLine("------------------------------------------------------------------");
            Console.WriteLine("This is the Battles Menu.");
            Console.WriteLine("------------------------------------------------------------------");
            Console.WriteLine("1. Display Battles by Province A-Z.");
            Console.WriteLine("2. Display Battles A-Z.");
            Console.WriteLine("3. Display Battles by Frequency High-Low.");
            Console.WriteLine("4. Return to Main.");
            Console.WriteLine();
        }
        public void GetInputM7()
        {   //method for acquring user input(for menus with seven options).

            Input =Console.ReadLine();

            while (Input != "1" && Input != "2" && Input != "3" && Input != "4" && Input != "5" && Input != "6" && Input != "7")
            {
                ImproperInput();
                GetInputM7();
            }
        }
        public void GetInputM4()
        {   //method for acquring user input(for menus with four options).

            Input = Console.ReadLine();

            while (Input != "1" && Input != "2" && Input != "3" && Input != "4")
            {
                ImproperInput();
                GetInputM4();
            }
        }
        public void ImproperInput()
        {   //method used to show user that they entered invalid data.

            Console.WriteLine("Data entered is invalid, '{0}' was not a number.",Input);
            Console.WriteLine("Enter valid data please.");
            Console.WriteLine();
        }
        public void MainMenuSelection()
        {   //method used to keep track of user menu choice.
            MainMenu();
            GetInputM7();

            switch(Input)
            {
                case "1": PrintSearchMenuSelection();
                        break;
                case "2": //Add to master array method
                        break;
                case "3": //Write to File work.
                        break;
                case "4": rosterColl.ReadFromFile();
                        break;
                case "5": SortMenuSelection();
                        break;
                case "6": BattlesMenuSelection();
                        break;
                case "7": //Program closes
                        break;
            }
        }
        public void PrintSearchMenuSelection()
        {   //method used to keep track of user menu choice.
            PrintSearchMenu();
            GetInputM7();

            switch (Input)
            {
                case "1": //Print the complete contents of the array.
                    break;
                case "2": //Print the full names of the roster.
                    break;
                case "3": //Print a complete list of the family names.
                    break;
                case "4": //Print the roster by family names.
                    break;
                case "5": //Print a complete list of all the factions.
                    break;
                case "6": //Print the roster by factions.
                    break;
                case "7": Console.Clear();
                    MainMenuSelection();
                    break;
            }
        }
        public void SortMenuSelection()
        {   //method used to keep track of user menu choice.
            SortMenu();
            GetInputM4();

            switch (Input)
            {
                case "1": //Sort the roster A-Z alphabetically.
                    break;
                case "2": // Sort the roster by family name A-Z.
                    break;
                case "3": //Sort the roster by faction name A-Z.
                    break;
                case "4": Console.Clear();
                    MainMenuSelection();
                    break;
            }
        }
        public void BattlesMenuSelection()
        {   //method used to keep track of user menu choice.
            BattlesMenu();
            GetInputM4();

            switch (Input)
            {
                case "1": //Sort the battles by Province A-Z.
                    break;
                case "2": //Sort the battles A-Z.
                    break;
                case "3": //Sort the battles by frequency High-Low.
                    break;
                case "4": Console.Clear();
                    MainMenuSelection();
                    break;
            }
        }
        public void OpenFileProcessFail()
        {   //method containing UI output for when the file cannot be opened.
            Console.WriteLine();
            Console.WriteLine("The file read failed.");
            
        }

        //properties
    }
}
