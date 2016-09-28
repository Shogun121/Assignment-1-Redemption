using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DynastyWarriorsApp
{
    class RosterCollection
    {
        //class used to store the array of characters and perform related tasks.

        //Backing Fields
        bool fileExists;        //determines if a file exists to read from.
        string _fullName;
        string _familyName;
        string _faction;

        //array declared to hold the roster.
        string[] Roster;

        //3 parameter constructor
        public RosterCollection(string FullName, string FamilyName, string Faction)
        {
            this._fullName = FullName;
            this._familyName = FamilyName;
            this._faction = Faction;
        }

        public void AddArrayItem()
        {   //method used to add a character to the current roster.


        }
        public void ReadFromFile()
        {   //method used to read the roster from a file.
            

        }
    }
}
