using System;
using System.Collections.Generic;

namespace _10.InteratingAcrossCollections
{
    // The compiler-generated code for a foreach loop
    public class MainListing1X73
    {
        class Person
        {
            public String FirstName { get; set; }
            public String LastName { get; set; }
        }
        public MainListing1X73()
        {
            var people = new List<Person>
            {
                new Person() {FirstName = "John", LastName = "Doe"},
                new Person() {FirstName = "Jane", LastName = "Doe"},
            };

            // Aqui seria o Foreach
            List<Person>.Enumerator e = people.GetEnumerator();
            try
            {
                Person v;
                while (e.MoveNext())
                {
                    v = e.Current;
                    Console.WriteLine(v.FirstName + " " + v.LastName);
                }

                Console.ReadLine();
            }
            finally
            {
                System.IDisposable d = e as  System.IDisposable;
                if (d != null) d.Dispose();
            }

            // If you change the value of e.Current to something else, the iterator pattern can’t determine
            // what to do when e.MoveNext is called. This is why it’s not allowed to change the value of the
            // iteration variable in a foreach statement.

        }
    }
}
