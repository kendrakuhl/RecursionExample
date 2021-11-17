using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace RecursionExample
{
    public class Person
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public List<Person> Contacts { get; set; } = new List<Person>();
        public string GetContacts()
        {
            StringBuilder retVal = new StringBuilder($"{FirstName} {LastName}'s contacts: {Environment.NewLine}");

            foreach (Person person in Contacts)
            {
                if (person.Contacts.Any())
                {
                    retVal.Append(person.GetContacts());
                }
                else
                {
                    retVal.Append($"{person.FirstName} {person.LastName}{Environment.NewLine}");
                }
            }

            return retVal.ToString();

        }
    }
}
