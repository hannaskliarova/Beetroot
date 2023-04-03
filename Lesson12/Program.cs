using Lesson12Library;

namespace Lesson12
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Jeans.AddNewJeans("High Waist", 1, 99.99);
            
            foreach (Jeans newJeans in Jeans.jeans)
            {
                Console.WriteLine("Jeans Type is: {0}, Quantity added: {1}, Price: {2}", newJeans._ProductType, newJeans._Quantity, newJeans._Price);
            }

            Buyer newBuyer = new Buyer();
            Buyer.AddNewBuyer("John", "Malcolm", "john@gmail.com", "+19844344324");

            Order.CalculateSum(5, 99.9);
            

        }
        
    }
}