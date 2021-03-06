﻿using System;


namespace _1.Persons
{
    public class Person
    {
        private string name;
        private int age;
        private string email;

        public string Name
        {
            get
            {
                return this.name;
            }
            set
            {
                if (string.IsNullOrEmpty(value))
                {
                    throw new ArgumentNullException("Name is empty!");
                }
                else
                {
                    this.name = value;
                }

            }
        }

        public int Age
        {
            get
            {
                return this.age;
            }
            set
            {
                if (value < 0 || value > 100)
                {
                    throw new ArgumentOutOfRangeException("Age must be [1...100]!");
                }
                else
                {
                    this.age = value;
                }
            }
        }

        public string Email
        {
            get
            {
                return this.email;
            }
            set
            {
                if (value != null && !value.Contains("@"))
                {
                    throw new ArgumentException("Not a valid e-mail address!");
                }
                else
                {
                    this.email = value;
                }

            }
        }

        public Person(string name, int age, string email)
        {
            this.Name = name;
            this.Age = age;
            this.Email = email;

        }

        public Person(string name, int age) : this(name, age, null) { }
        public override string ToString()
        {
            return string.Format("Name: {0}, Age: {1}", this.Name, this.Age) + (this.Email == null ? "" : ", email: " + this.Email);
        }

    }
    class Program
    {
        static void Main(string[] args)
        {
            Person first = new Person("Ivan", 20);
            Person second = new Person("Maria", 23, "maria@abv.bg");
            Console.WriteLine(first);
            Console.WriteLine(second);
            Console.ReadLine();



        }
    }
}
