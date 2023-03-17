using System.Text.Json;

namespace Homework7_Lesson9_
{
    internal class Program
    {
        public static void Main(string[] args)
        {

            //string[] phoneBookUsers = File.ReadAllLines("Phonebook.txt");

            //Console.ReadLine();

            //Person[] persons = new[]
        //{
            //new Person("Hanna","Skliarova", 25),
            //new Person("Melanie","Wilson",25),
            //new Person("Gregory","Davidson",26),
            //new Person("Donald","Rochester",25),
            //new Person("Din","Thompson",30)
        //};

            Person[] Book = Deserialize();


        }

        public static Person[] Deserialize()
        {
            using (var fileStream = new FileStream("C:\\Users\\admin\\source\\repos\\Beetroot\\Homework7(Lesson9)\\Book.json", FileMode.OpenOrCreate))
            {
                return JsonSerializer.Deserialize<Person[]>(fileStream);
            }
        }

        /*public static void Serialize(Person[] persons)
        {
            using (var fileStream =
                   new FileStream("Book.json",
                       FileMode.OpenOrCreate))
            {
                JsonSerializer.Serialize(fileStream, persons);
            }
        }*/
        public class Person
        {
            
            public string FirstName  { get; set; }

            public string LastName { get; set; }

            public int Age { get; set; }

            public Person(string firstName, string lastName , int age)
            {
                FirstName = firstName;
                LastName = lastName;
                Age = age;
            }

            public void PrintInfo() => Console.WriteLine($"First name: {FirstName} Last name: {LastName} Age: {Age}");
        }

    }
}