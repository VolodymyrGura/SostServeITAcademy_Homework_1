using System;

namespace SostServeITAcademy_Homework_1.Models
{
    public class Person
    {
        private int _age;

        public Person(string name, int age)
        {
            Name = name;
            Age = age;
        }

        public string Name { get; set; }

        public int Age
        {
            get => _age;
            set
            {
                if (Age < 0)
                {
                    throw new ArgumentException("Age cannot be negative", nameof(value));
                }

                _age = value;
            }
        }

        public override string ToString()
        {
            return $"Name {Name} Age {Age} ";
        }
    }
}
