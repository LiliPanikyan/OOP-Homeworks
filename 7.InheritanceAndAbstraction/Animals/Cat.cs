﻿
namespace Animals
{
    public class Cat : Animal
    {
        public Cat(string name, double age, Genders gender)
            : base(name, age, gender) { }

        public override string ProduceSound()
        {
            return "Myauuuuuu";
        }
    }
}
