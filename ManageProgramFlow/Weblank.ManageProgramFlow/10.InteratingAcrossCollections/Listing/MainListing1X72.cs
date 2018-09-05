using System;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;

namespace _10.InteratingAcrossCollections
{
    // Changing items in a foreach
    public class MainListing1X72
    {
        class Person
        {
            public String FirstName { get; set; }
            public String LastName { get; set; }
        }
        // Can not Change Foreach Iteration Variable
        public MainListing1X72()
        {
            var people = new List<Person>
            {
                new Person() {FirstName = "John", LastName = "Doe"},
                new Person() {FirstName = "Jane", LastName = "Doe"},
            };

            foreach (Person p in people)
            {
                p.LastName = "Changed"; // This is allowed
                Console.WriteLine(p.FirstName + " " + p.LastName);
                
                // p = new Person(); This gives a compile error

            }

            Console.ReadLine();
        }
    }
}
