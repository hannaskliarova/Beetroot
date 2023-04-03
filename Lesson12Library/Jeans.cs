using System;

namespace Lesson12Library;

public class Jeans : IProduct
{
    public string _ProductType { get; set; }
    public int _Quantity { get; set; }
    public double _Price { get; set; }

    public static List<Jeans> jeans = new List<Jeans>();
    public static void AddNewJeans(string ProductType, int Quantity, double Price)
    {
        Jeans newJeans = new Jeans();
        newJeans._ProductType = ProductType;
        newJeans._Quantity = Quantity;
        newJeans._Price = Price;
        jeans.Add(newJeans);

    }




}