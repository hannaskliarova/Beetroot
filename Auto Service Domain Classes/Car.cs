using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Auto_Service_Domain_Classes
{
    public class Car : Wheel
    {
        private int numberOfWheels;
        public Car(double Diameter, string ProducedBy, int NumberOfWheels) : base(Diameter, ProducedBy)
        {
            NumberOfWheels = numberOfWheels;
        }
        public int NumberOfWheels { get; set; }
        
        public void CarCharacteristics()
        {
            base.Characteristics();
            Console.WriteLine($"The number of wheels is: " + numberOfWheels);

        }

        
    }
}
