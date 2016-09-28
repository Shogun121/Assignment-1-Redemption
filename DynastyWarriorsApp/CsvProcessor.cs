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
                int counter = 0;

                //store a line in 'inputLine' while a line can be read.
                while((inputLine=streamReader.ReadLine())!=null)
                {
                    /*Call the method reading one line at a time; passing in the array
                     * and the counter.
                     * */
                    ReadLine(inputLine,rosterArray,counter++);
                }

                //Let program know that the file was read successfully.
                return true;
            }
            catch(Exception e)
            {
                uI = new UserInterface();

                uI.OpenFileProcessFail();
                Console.WriteLine(e.ToString());
                Console.WriteLine(e.StackTrace);

                //return false to let the program know that the file read failed.
                return false;
            }
            

            
        }
        public void ReadLine(string inputLine,RosterCollection[] rosterArray,int index)
        {   //method to split the readline into segments.

            string[] parts = inputLine.Split(',');

            //variable portions of the array splitting the read line.
            string fullName = parts[0];
            string familyName = parts[1];
            string faction = parts[2];

            //create an instance of the rosterArray to hold the incoming character.
            rosterArray[index] = new RosterCollection(fullName,familyName,faction);
        }
    }
}
