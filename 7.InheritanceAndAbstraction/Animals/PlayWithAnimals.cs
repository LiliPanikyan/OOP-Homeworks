using System;
using System.Linq;

namespace Animals
{
    class PlayWithAnimals
    {
        static void Main(string[] args)
        {
           Animal[] zoo= new Animal[]
            {
                new Frog("Zelenka", 5.3, Genders.Female),
                new Dog("Sharo", 7, Genders.Male),
                new Cat("Moly", 2, Genders.Female),
                new Kitten("Doly", 3.5),
                new TomCat("Tomas", 5),
                new TomCat("Bary", 5),
                new Kitten("Shushi", 3),
                new Dog("Buki", 5,Genders.Male)
            };

           var averageAge =
               from animal in zoo
               group animal by new { GroupName = animal.GetType().Name } into gr
               select new
               {
                   GroupName = gr.Key.GroupName,
                   AvarageAge = gr.Average(an => an.Age)
               };

           foreach (var animal in averageAge)
           {
               Console.WriteLine(String.Format("{0} -->> AvarageAge: {1:0.00}years.", animal.GroupName, animal.AvarageAge));
           }
           Console.ReadLine();
        }
    }
}
