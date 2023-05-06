

namespace EntityFramework
{
    internal class Program
    {
        static void Main(string[] args)
        {
            try
            {
                using (var context = new MyDbContext())
                {
                    if (context.Persons.Any())
                    {
                        var count = context.Persons.Count();
                        Console.WriteLine(count);
                    }
                    else
                    {
                        Console.WriteLine("No records found in the 'Persons' table.");
                    }
                }
            }
            catch (Exception exception)
            {
                Console.WriteLine($"An error occurred: {exception}");
            }
        }
    }
}