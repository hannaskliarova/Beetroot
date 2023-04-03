using System.Threading.Channels;

namespace Lesson12Library;

public class Order : IOrder, IProduct
{
    public string Guid { get; set; }
    public DateTime Date { get; set; }
    public IBuyer Buyer { get; set; }
    public static double Total { get; set; }
    public string _ProductType { get; set; }

    public int _Quantity { get; set; }
    public double _Price { get; set; }
    public static List<IProduct> Products = new List<IProduct>();
    public static void CalculateSum(int _Quantity, double _Price)
    {
        
        double sum = 0;
        foreach (IProduct product in Products)
        {
            sum += product._Price * product._Quantity;
        }
        Total = sum;

        Console.WriteLine(sum);
    }
}