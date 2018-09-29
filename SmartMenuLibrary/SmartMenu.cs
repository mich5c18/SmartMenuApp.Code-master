using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FunctionLibrary;

namespace SmartMenuLibrary
{
    public class SmartMenu
    {
        public void LoadMenu(string path)
        {
            string line;
            string Selection = Console.ReadLine();

            Console.WriteLine("Vælg sprog");
            Console.WriteLine("Chose language");
            Console.WriteLine("1 for dansk");
            Console.WriteLine("2 for english");
            Console.ReadLine();

            if (Selection == "1")
            {

                // Read the file and display it line by line.  
                System.IO.StreamReader file = new System.IO.StreamReader(@"C:/Users/Michael/Desktop/ProjektProgrammering/SmartMenuApp.Code-master/SmartMenuApp/Sprogvalg.txt");
                while ((line = file.ReadLine()) != null)
                {
                    Console.WriteLine(line);
                }
            }
            else if (Selection == "2")
            {

                // Read the file and display it line by line.  
                System.IO.StreamReader file = new System.IO.StreamReader(@"C:/Users/Michael/Desktop/ProjektProgrammering/SmartMenuApp.Code-master/SmartMenuApp/Sprogvalg.txt");
                while ((line = file.ReadLine()) != null)
                {
                    Console.WriteLine(line);
                }
            }
        }
        public void Activate()
        {
            // Implement ...
        }
    }
}
