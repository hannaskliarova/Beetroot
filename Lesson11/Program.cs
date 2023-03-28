using Auto_Service_Domain_Classes;

namespace Lesson11
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Wheel wheel = new Wheel(20, "Michellin");
            wheel.Characteristics();
            Car car= new Car(25, "SomeText", 4);
            car.CarCharacteristics();
        }
    }
}