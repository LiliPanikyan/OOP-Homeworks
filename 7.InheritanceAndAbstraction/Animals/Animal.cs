using System;

namespace Animals
{
    public abstract class Animal:ISound
    {
        protected string name;
        protected double age;
        protected Genders gender;

        public Animal(string name, double age, Genders gender)
        {
            this.Name = name;
            this.Age = age;
            this.Gender = gender;
        }

        public string Name
        {
            get
            {
                return this.name;
            }
            set
            {
                if(string.IsNullOrEmpty(value))
                {
                    throw new ArgumentNullException("Name is requered!");
                }
                this.name = value;
            }
        }

        public double Age
        {
            get
            {
                return this.age;
            }
            set
            {
                if(value < 0)
                {
                    throw new ArgumentOutOfRangeException("Age can't be negative number!");
                }
                this.age = value;
            }
        }

        public Genders Gender { get; set; }       

        public abstract string ProduceSound();
    }
}
