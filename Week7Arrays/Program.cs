using System;

namespace Week7Arrays
{
    class Program
    {
        static void Main(string[] args)
        {
            //programm kuvab kasutajale hommikusöögi menüüd
            //programm kuvab kasutajal teha valik
            //programm kuvab kasutaja valikut konsoolis

            string[] menu = { "Omlett", "pannkoogid", "keedumuna", "neljaviljapuder", "singivõileib"};
            Console.WriteLine($"Tere, meie menüüs on {menu.Length} valikut.");

            //asendamine:
            //  menu[4] = "juustuvõileib";
            //  menu[3] = "kaerapuder";    

            Console.WriteLine("Tänases menüüs on:");
            for (int i = 0; i < menu.Length; i++)
            {
                if(menu[i] == "neljaviljapuder")
                {
                    menu[i] = "kaerapuder";
                }
                else if (menu[i] == "singivõileib")
                {
                    menu[i] = "juustuvõileib";
                }
                Console.WriteLine(menu[i]);
            }
            Console.WriteLine("Tee oma valikut (sisesta numbrid 1-5):");
            int userChoice = Convert.ToInt32(Console.ReadLine()) - 1;

            Console.WriteLine($"Olete valinud: {menu[userChoice]}");


          /* 
           * for (int i = 0; i < menu.Length; i++) 

            {
                Console.WriteLine(menu[i]);
            }

          */
          /*
          foreach(string menuElement in menu)
          {
                Console.WriteLine(menuElement);
          }
          */






        }
    }
}
