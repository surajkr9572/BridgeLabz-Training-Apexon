using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Builder_Design_Pattern
{
    public class Shop
    {
        private VehicleBuilder? builder;
        public void Construct(VehicleBuilder vehiclebuilder)
        {
            builder=vehiclebuilder;
            builder.BuildFrame();
            builder.BuildEngine();
            builder.BuildWheels();
            builder.BuildDoors();
        }
        public void ShowVehicle()
        {
            builder?.Vehicle.show();
        }
    }
}
