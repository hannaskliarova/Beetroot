using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Auto_Service_Domain_Classes
{
    public class Wheel
    {
        public double Diameter { get; set; }
        public string ProducedBy { get; set; }
        public Wheel(double Diameter, string ProducedBy)
        { 
            this.Diameter = Diameter;
            this.ProducedBy = ProducedBy;
        }

        public void Characteristics ()
        {
            Console.WriteLine($"Diameter of your wheels is: {Diameter}\nThe wheels are produced by: {ProducedBy}\n");
        }

    }
}
