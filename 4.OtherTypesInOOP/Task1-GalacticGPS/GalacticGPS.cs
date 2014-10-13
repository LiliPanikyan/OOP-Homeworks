using System;

namespace GalacticGPS
{
    class GalacticGPS
    {

        public static void Main(string[] args)
        {
            Location home = new Location(18.037986, 28.870097, Planet.Earth);
            Console.WriteLine(home);

            Location guest = new Location(6.66666, 9.99999, Planet.Jupiter);
            Console.WriteLine(guest);
            Console.ReadLine();
        }
    }
}
