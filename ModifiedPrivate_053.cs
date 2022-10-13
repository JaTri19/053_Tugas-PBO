using System;

namespace ModifiedPrivate
{
    class Program
    {
        class Person
        {
            private string name = "Jarwo Trimulyo";
            static void Main(string[] args)
            {
                Person person = new Person();
                Console.WriteLine(person.name);
            }
        }
    }
}
