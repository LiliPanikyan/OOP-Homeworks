using System;
using System.Text;


namespace _2.Laptop_Shop
{
    public class Laptop
    {
        private string model;
        private string manufacturer;
        private string processor;
        private string ram;
        private string graphicsCard;
        private string hdd;
        private string screen;
        private string battery;
        private string batteryLife;
        private decimal price;

        public Laptop(string model, decimal price)
        {
            this.Model = model;
            this.Price = price;
        }
        public Laptop(string model, decimal price, string manufacturer = null, 
                    string processor = null, string ram = null, string hdd = null, 
                    string graphicsCard = null, string battery = null, string batteryLife = null, string screen = null): this(model, price)
        {
            this.Manufacturer = manufacturer;
            this.Processor = processor;
            this.Ram = ram;
            this.Hdd = hdd;
            this.GraphicsCard = graphicsCard;
            this.Battery = battery;
            this.batteryLife = batteryLife;
            this.Screen = screen;

        }

        public string Model
        {
            get
            {
                return this.model;
            }
            set
            {
                if (string.IsNullOrEmpty(value))
                {
                    throw new ArgumentNullException("Model is empty!");
                }
                else
                {
                    this.model = value;
                }

            }
        }
        

        public decimal Price {
            get
            {
                return this.price;
            }
            set
            {
                if (value < 0) throw new ArgumentOutOfRangeException("Price can not be negative!");
                this.price = value;
            }
        }

        public string Manufacturer { get; set; }

        public string Processor { get; set; }

        public string Ram { get; set; }

        public string Hdd { get; set; }

        public string GraphicsCard { get; set; }

        public string Battery { get; set; }

        public string Screen { get; set; }

        public string BatteryLife { get; set; }

        public override string ToString()
        {
            StringBuilder laptopStr = new StringBuilder();
            laptopStr.AppendLine("model: " + this.Model);
            if (this.Manufacturer != null)
            {
                laptopStr.AppendLine("manufacturer: " + this.Manufacturer);
            }
            
            if (this.Processor != null)
            {
                laptopStr.AppendLine("processor: " + this.Processor);
            }
            if (this.Ram != null)
            {
                laptopStr.AppendLine("RAM: " + this.Ram);
            }
            if (this.Hdd != null)
            {
                laptopStr.AppendLine("HDD: " + this.Hdd);
            }
            if (this.Screen != null)
            {
                laptopStr.AppendLine("screen: " + this.Screen);
            }
            if (this.Battery != null) 
            {
                laptopStr.AppendLine("battery: " + this.Battery);
            }
            if(this.BatteryLife != null)
            {
                laptopStr.AppendLine("battery life: " + this.BatteryLife);
            }
            if (this.Battery != null)
            {
                laptopStr.AppendLine(this.Battery.ToString());
            }
           

            return laptopStr.AppendLine("price: " + this.Price).ToString();
        }

        
    }

    class Program
    {
        static void Main(string[] args)
        {
            Laptop shortData = new Laptop("Lenovo Yoga 2 Pro", (decimal)869.88);
            Laptop fullData=new Laptop("ASUS G750",(decimal)2949.99,"ASUS","Intel Core i7-4700HQ","8GB","1TB","NVIDIA GeForce GTX 880M","Li-Ion, 8-cells","5 hours","17.3inch");
            Console.WriteLine(shortData);
            Console.WriteLine(fullData);
            Console.ReadLine();

        }
    }
}
