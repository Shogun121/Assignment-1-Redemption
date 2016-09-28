using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace DynastyWarriorsApp
{
    class CsvProcessor
    {   //class used to handle accessing the file in question storing the character roster.
        StreamReader streamReader;

        //class instantiations.
        UserInterface uI;

        /*
         * Method used to validate the file we are trying to read from.
         * */
        public bool ReadCSVFile(string pathToCsv, RosterCollection[] rosterArray)
        {
            //File reference used to handle the file.
            streamReader = null;

            try
            {
                //Create a variable to hold one line at a time while reading.
                string inputLine;

                //Instantiate a streamReader to handle the file(searching in given location).
                streamReader = new StreamReader(pathToCsv);

                //declare a counter to be used later.
                int counter;



                //Let program know that the file was read successfully.
                return true;
            }
            catch(Exception e)
            {
                uI = new UserInterface();

                uI.OpenFileProcessFail();
                //Console.WriteLine(e.ToString());
                //Console.WriteLine(e.StackTrace);

                //return false to let the program know that the file read failed.
                return false;
            }
            

            
        }
    }
}
