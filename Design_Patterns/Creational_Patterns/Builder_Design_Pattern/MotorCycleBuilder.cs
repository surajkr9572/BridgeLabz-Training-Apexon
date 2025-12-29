using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Builder_Design_Pattern
{
    public class MotorCycleBuilder:VehicleBuilder
    {
        public MotorCycleBuilder() : base(VehicleType.MotorCycle) { }
        public override void BuildFrame() => Vehicle[PartType.Frame] = "MotorCycle Frame";
        public override void BuildEngine() => Vehicle[PartType.Engine] = "500 cc";
        public override void BuildWheels() => Vehicle[PartType.Wheel] = "2";
        public override void BuildDoors() => Vehicle[PartType.Door] = "0";

            
    }
}
