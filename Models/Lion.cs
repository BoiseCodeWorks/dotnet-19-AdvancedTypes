using System;

namespace AdvancedTypes.Models
{
    public class Lion
    {
        // NOTE `member` is anything that's defined within a class - properties, methods, etc.
        public string Name { get; private set; } //NOTE get refers to who can access the value of this property and set refers to who can reassign the value of this property
        public int Age { get; set; }
        public int Legs { get; set; }
        public bool HasTail { get; set; }
        public string Gender { get; set; }


        public void Eat(string food)
        {
            Console.WriteLine($"{Name} is eating all the {food}. Nam Nam Nam...");
        }

        public void ChangeName(string newName)
        {
            string oldName = Name;
            Name = newName; //because ChangeName is a memeber of the Lion class he has scope to set the value of the Name property
            Console.WriteLine($"My name's not {oldName} anymore, it's {Name}! ROAR!");
        }

        // NOTE Constructor method runs when a new instance is created. Class and Constructor must share the same name.
        // NOTE hasTail below is an optional parameter (if no 5th argument provided then defaults to true).
        public Lion(string name, int age, int numberOfLegs, string gender, bool hasTail = true)
        {
            Name = name;
            Age = age;
            Legs = numberOfLegs;
            Gender = gender;
            HasTail = hasTail;
        }
    }
}