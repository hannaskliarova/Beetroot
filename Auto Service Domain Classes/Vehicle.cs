using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Auto_Service_Domain_Classes
{
    public class Vehicle : Car
    {

        public string type {get; set;}

        public Wheel NumberOfWheels { get; set; }
        private List <Car> cars;
        public Vehicle(double Diameter, string ProducedBy, int NumberOfWheels, string type) : base(Diameter, ProducedBy, NumberOfWheels)
        {
            cars = new List <Car>();   
        }


    }
}
