using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3.PCCatalog
{
    public class Computer
    {
        private string name;
        private List<Component> componets = new List<Component>();
        private decimal price;
        public string Name
        {
            get
            {
                return this.name;
            }
            set
            {
                ValidateData.checkStringsValue(value, "name");
                this.name = value;
            }
        }
        public decimal Price
        {
            get
            {
                return this.price;
            }
        }

        public Computer(string name, Component hdd, Component procesor, Component graficsCard, Component ram, Component discSSD)
        {
            this.Name = name;
            
            this.componets.Add(hdd);
            this.componets.Add(procesor);
            this.componets.Add(graficsCard);
            this.componets.Add(ram);
            this.componets.Add(discSSD);
            foreach (Component componet in this.componets)
            {
                this.price += componet.Price;
            }
        }
        public Computer(string name, Component hdd, Component procesor, Component graficsCard, Component ram,Component discSSD, params Component[] components) :
            this(name,hdd, procesor, graficsCard, ram, discSSD)
        {
            this.componets.AddRange(components);
            foreach (Component componet in components)
            {
                this.price += componet.Price;
            }
        }
        
        public void writeToConsole()
        {
            Console.WriteLine("{0}; total price: {1:f2} $.", this.Name, this.price);
            foreach (var component in this.componets)
            {
                Console.WriteLine("{0}-->> price: {1:f2} $|", component.Name, component.Price);
            }
        }
    }
    
}
