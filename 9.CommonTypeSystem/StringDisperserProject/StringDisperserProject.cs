using System;

namespace StringDisperserProject
{
    public class StringDisperserProject
    {
        static void Main()
        {
            StringDisperser originalTeam = new StringDisperser("Pesho", "Gosho", "Ivan");
            Console.WriteLine("ORIGINAL OBJECT: {0}", originalTeam.ToString());

            StringDisperser clonedTeam = (StringDisperser)originalTeam.Clone();
            clonedTeam.DeveloperName = "Asen";
            clonedTeam.TeamLiderName = "Bobi";
            Console.WriteLine("CLONED OBJECT: {0}", clonedTeam.ToString());

            Console.WriteLine("ORIGINAL AFTER CLONING: {0}\n", originalTeam.ToString());

            Console.WriteLine("Compare original and cloning with:");
            Console.WriteLine("Equals() method --> " + originalTeam.Equals(clonedTeam));
            Console.WriteLine("== operator --> " + (originalTeam == clonedTeam));
            Console.WriteLine("!= operator --> " + (originalTeam != clonedTeam));
            Console.WriteLine("CompareTo() method --> " + originalTeam.CompareTo(clonedTeam) + "\n");

            Console.WriteLine("Original hash value: {0}", originalTeam.GetHashCode());
            Console.WriteLine("Cloning hash value: {0}\n", clonedTeam.GetHashCode());

            foreach (var ch in originalTeam)
            {
                Console.Write(ch + " ");
            }
            Console.WriteLine();

            Console.ReadLine();
        }
    }
}
