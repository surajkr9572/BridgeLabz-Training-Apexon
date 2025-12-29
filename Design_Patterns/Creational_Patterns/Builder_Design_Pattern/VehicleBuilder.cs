using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Builder_Design_Pattern
{
    public abstract class VehicleBuilder(VehicleType vehicletype)
    {
        public Vehicle Vehicle { get; private set; } = new Vehicle(vehicletype);
        public abstract void BuildFrame();
        public abstract void BuildEngine();
        public abstract void BuildWheels();
        public abstract void BuildDoors();
    }
    
}
