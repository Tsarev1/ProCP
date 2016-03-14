using System.Drawing;

namespace Traffic_Light_Simulator
{
    public class Car : IDrawable, IMoveable
    {
        public Direction Direction { get; set; }
        public int Flow { get; set; }//speed?
        public Lane Lane { get; set; }// do we need that?

        public Rectangle HitBox { get; set; }
        public Image Image { get; set; }
        public Point Position { get; set; }

        public void Move() { }

    }
}