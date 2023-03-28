using System.Reflection;

namespace Auto_Service_Domain_Classes
{
    public class AutoService
    {
       private string name;
        public string Name
        { 
            get { return name; }
            set { name = value; }
        }

        private List<Vehicle> vehicles;
        public AutoService()
        {
            vehicles = new List<Vehicle>();
        }

        public void AddVehicle (Vehicle vehicle)
        {
            vehicles.Add(vehicle);
        }
        public void PrintName (string name)
        {
            Console.WriteLine (name);
        }

    }
}