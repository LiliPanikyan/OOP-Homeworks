using System;
using System.Collections.Generic;

namespace _3.PCCatalog
{
    
    class PCCatalog
    {
        static void Main(string[] args)
        {

            Component hdd = new Component(name: "Western Digital HDD", price: 231m, details: "Capacity: 3 TB");
            Component procesor = new Component(name: "Intel Core i7-3820", price: 314.99m, details: "Speed: 3.6GHz - 3.8GHz");
            Component graficsCard = new Component(name: "GeForce GTX 980", price: 549.99m, details: "Memory: 4GB");
            Component ram = new Component(name: "DDR3-1600Mhz", price: 67.99m, details: "8GB (2*4GB)");
            Component discSSD = new Component(name: "Goldendisk 2.5 SSD", price: 298.50m, details: "550-500MB/S, 512GB");


            Computer theFlash = new Computer("The Flash", hdd, procesor, graficsCard, ram, discSSD);
            Computer theTurbo = new Computer("Turbo", hdd, procesor, graficsCard, ram,discSSD);

            List<Computer> computers = new List<Computer>() { theFlash, theTurbo};



            
            foreach (var computer in computers)
            {
                computer.writeToConsole();
                Console.WriteLine();
            }
            Console.ReadLine();
        }
    }
}
