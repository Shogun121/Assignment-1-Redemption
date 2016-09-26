using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DynastyWarriorsApp
{
    class Program
    {
        static void Main(string[] args)
        {   //class declarations necessary to use external methods.
            UserInterface uI = new UserInterface();

            //UI methods running through main.
            //The goal is for the entire UI to run through this method.
            uI.MainMenuSelection();

        }
    }
}
