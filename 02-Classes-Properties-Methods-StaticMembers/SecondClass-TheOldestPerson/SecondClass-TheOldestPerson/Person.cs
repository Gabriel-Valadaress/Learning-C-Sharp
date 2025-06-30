using System;

namespace SecondClass_TheOldestPerson
{
    class Person
    {
        public string Name;
        public int Age;

        public string AgeComparison(Person otherPerson)
        {
            if (this.Age > otherPerson.Age)
            {
                return $"The oldest person is {this.Name}";
            }
            else if (this.Age < otherPerson.Age)
            {
                return $"The oldest person is {otherPerson.Name}";
            }
            else
            {
                return $"Both {this.Name} and {otherPerson.Name} are {this.Age} years old";
            }
        }
    }

}
