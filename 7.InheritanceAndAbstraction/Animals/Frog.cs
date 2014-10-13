
namespace Animals
{
    public class Frog : Animal
    {
        public Frog(string name, double age, Genders gender)
            : base(name, age, gender) { }

        public override string ProduceSound()
        {
            return "Kuak";
        }
        
    }
}
