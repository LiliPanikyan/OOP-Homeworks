using System;

namespace StudentClassTest
{
    public class Student
    {
        private string name;
        private int age;

        public event EventHandler<PropertyChangedEventArgs<string>> PropertyChanged;

        public string Name
        {
            get
            {
                return this.name;
            }
            set
            {
                if (value != null)
                {
                    this.OnPropertyChanged(new PropertyChangedEventArgs<string>("Name", this.name, value));
                    this.name = value;
                }
                else
                {
                    throw new ArgumentNullException();
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
                if (value > 0)
                {
                    this.OnPropertyChanged(new PropertyChangedEventArgs<string>("Age", this.Age.ToString(), value.ToString()));
                    this.age = value;
                }
                else
                {
                    throw new ArgumentOutOfRangeException();
                }
            }
        }

        public Student(string name, int age)
        {
            this.name = name;
            this.age = age;
        }

        protected virtual void OnPropertyChanged(PropertyChangedEventArgs<string> e)
        {
            if (null != this.PropertyChanged)
            {
                this.PropertyChanged(this, e);
            }
        }


    }
}
