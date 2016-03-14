using System.Collections.Generic;

namespace Traffic_Light_Simulator
{
    public class ZebraCrossing:BaseCrossing
    {
        public IList<Pedestrian> Pedestrians { get; set; }
        public IList<Zebra> Zebras { get; set; } 
    }
}