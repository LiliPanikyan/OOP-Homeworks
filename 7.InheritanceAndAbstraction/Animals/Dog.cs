
namespace Animals
{
    public class Dog:Animal
    {
        public Dog(string name, double age, Genders gender)
            : base(name, age, gender) { }

        public override string ProduceSound()
        {
            return "Bauuu";
        }
    }
}
