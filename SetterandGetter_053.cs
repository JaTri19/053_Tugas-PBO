using System;

namespace SetterandGetter
{
    public class Student
    {
        // Declare name field
        private string name;
        // Declare name property
        public string Name
        {
            get
            {
                return name;
            }
            set
            {
                name = value;
            }
        }
    }
    class TestStudent
    {
        // Main Method
        public static void Main(string[] args)
        {
            Student s = new Student();
            // calls set accessor of the property Name,
            // and pass "GFG" as value of the
            // standard field 'value'.
            s.Name = "Jarwo Trimulyo";
            // displays GFG, Calls the get accessor
            // of the property Name.
            Console.WriteLine("Name: " + s.Name);
        }
    }
}
