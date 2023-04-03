namespace Lesson12Library;

public interface IOrder
{
    public string Guid { get; set; }
    public DateTime Date { get; set; }
    IBuyer Buyer { get; set; }
    public static double Total { get; set; }
    int _Quantity { get; set; }


}