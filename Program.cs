using System;
using System.Collections.Generic;

namespace RecursionExample
{
    public class Program
    {
        private static void Main(string[] args)
        {
            Person person = GetPersons();

            Console.WriteLine(person.GetContacts());
        }

        public static Person GetPersons()
        {
            Person person = new Person
            {
                FirstName = "First",
                LastName = "Level",
                Contacts = new List<Person>
                {
                    new Person{ FirstName = "Second 1", LastName = "Level", Contacts = new List<Person>{ new Person{ FirstName = "Third 1.1", LastName = "Level" } } },
                    new Person{
                        FirstName = "Second 2",
                        LastName = "Level",
                        Contacts = new List<Person>(){
                            new Person{ FirstName = "Third 2.1", LastName = "Level"},
                            new Person { FirstName = "Third 2.2", LastName = "Level"}
                        }}
                }
            };

            return person;
        }
    }
}
