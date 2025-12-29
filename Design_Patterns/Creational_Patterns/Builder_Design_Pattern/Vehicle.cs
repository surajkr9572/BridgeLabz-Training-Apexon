using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Builder_Design_Pattern
{
    public class Vehicle(VehicleType vehicleType)
    {
        private readonly Dictionary<PartType, string> parts = [];
        private readonly VehicleType vehicleType = vehicleType;
        public string this[PartType Key]
        {
            get => parts[Key];
            set => parts[Key] = value;
        }
        public void show()
        {
            Console.WriteLine($"Vehicle Types {vehicleType}");
            Console.WriteLine($"Frame : {this[PartType.Frame]}");
            Console.WriteLine($"Engine : {this[PartType.Engine]}");
            Console.WriteLine($"Wheels : {this[PartType.Wheel]}");
            Console.WriteLine($"Doors : {this[PartType.Door]}");
        }
    }
    
}
