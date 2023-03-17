using System.Collections;
using System.Text.Json;


namespace Homework7_Lesson9_
{
    internal class Program
    {
        public static void Main(string[] args)
        {

            Person[] UsersFromBook = Deserialize();

            Array.Sort(UsersFromBook, new PersonComparer());

            Array.ForEach<Person>(UsersFromBook, p => Console.WriteLine(p.FirstName + " " + p.LastName));

        }

        public static Person[] Deserialize()
        {
            using (var fileStream = new FileStream("Book.json", FileMode.OpenOrCreate))
            {
                return JsonSerializer.Deserialize<Person[]>(fileStream);
            }
        }

        public class Person
        {
            
            public string FirstName  { get; set; }

            public string LastName { get; set; }

            public Person(string firstName, string lastName)
            {
                FirstName = firstName;
                LastName = lastName;
            }
        }

        class PersonComparer : IComparer
        {
            public int Compare(object x, object y)
            {
                return (new CaseInsensitiveComparer()).Compare(((Person)x).LastName, ((Person)y).LastName);
                
            }
          
        }

    }
}