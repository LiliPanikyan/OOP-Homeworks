
namespace Animals
{
    public class TomCat : Cat, ISound
    {
        public TomCat(string name, double age)
            : base(name, age, Genders.Male) { }

        public override string ProduceSound()
        {
            return "Where is the mouse???";
        }
    }
}
