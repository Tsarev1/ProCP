using System.Drawing;

namespace Traffic_Light_Simulator
{
    public class Pedestrian : IDrawable, IMoveable
    {
        public Rectangle HitBox { get; set; }
        public Image Image { get; set; }
        public Point Position { get; set; }

        public void Move() { }
    }
}