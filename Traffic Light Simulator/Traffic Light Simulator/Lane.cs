using System.Collections.Generic;
using System.Drawing;

namespace Traffic_Light_Simulator
{
    public class Lane
    {
        public Direction LaneDirection { get; set; }
        public Rectangle HitBox { get; set; }
        public IList<Car> Cars { get; set; }
    }
}