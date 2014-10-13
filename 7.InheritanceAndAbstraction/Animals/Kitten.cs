
namespace Animals
{
    public class Kitten:Cat, ISound
    {
        public Kitten(string name, double age)
            : base(name, age, Genders.Female) { }

        public override string ProduceSound()
        {
            return "Mmrrrrrr";
        }

    }
}
