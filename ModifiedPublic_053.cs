using System;

namespace ModifiedPublic
{
    class Program
    {
        class Person
        {
            public string name = "Jarwo Trimulyo";
        }

        class program
        {
            static void Main(string[] args)
            {
                Person person = new Person();
                Console.WriteLine(person.name);
            }
        }
    }
}
