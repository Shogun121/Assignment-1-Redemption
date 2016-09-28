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

        //class instantiations necessary to run methods.
        CsvProcessor Csv;
        RosterCollection[] Roster;

        //Backing Fields
        bool onceRead;        //determines if a file has been read.

        //portions of an array record.
        string _fullName;
        string _familyName;
        string _faction;

        


        //0 parameter constructor
        public RosterCollection()
        {

        }
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
            Csv = new CsvProcessor();
            Csv.ReadCSVFile("debug",Roster);

        }
    }
}
