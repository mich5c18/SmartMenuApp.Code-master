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
            /*string line;
            string selection = Console.ReadLine();
            //string input = Console.ReadLine();

            Console.WriteLine("Vælg sprog");
            Console.WriteLine("Chose language");
            Console.WriteLine("1 for dansk");
            Console.WriteLine("2 for english");
            Console.ReadLine();
            //int selection = int.Parse(input);

            if (selection == "1")
            {

                // Read the file and display it line by line.  
                System.IO.StreamReader file = new System.IO.StreamReader(@"C:/Users/Michael/Desktop/ProjektProgrammering/SmartMenuApp.Code-master/SmartMenuApp/Sprogvalg.txt");
                while ((line = file.ReadLine()) != null)
                {
                    Console.WriteLine(line);
                }
            }
            else if (selection == "2")
            {

                // Read the file and display it line by line.  
                System.IO.StreamReader file = new System.IO.StreamReader(@"C:/Users/Michael/Desktop/ProjektProgrammering/SmartMenuApp.Code-master/SmartMenuApp/Sprogvalg.txt");
                while ((line = file.ReadLine()) != null)
                {
                    Console.WriteLine(line);
                }
            }*/

            //Opens up the text file and displays every line in the console.
            //The while loop stops the program at then end of the file
            System.IO.StreamReader reader = new System.IO.StreamReader(@"C:/Users/Michael/Desktop/ProjektProgrammering/SmartMenuApp.Code-master/SmartMenuApp/Sprogvalg.txt");
            while (reader.EndOfStream == false)
            {
                string line = reader.ReadLine();
                Console.WriteLine(line);
            }
            reader.Close();
        }
        public void Activate()
        {
            // Implement ...
        }
    }
}
