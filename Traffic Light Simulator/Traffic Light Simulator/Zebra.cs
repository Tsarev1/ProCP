using System.Drawing;

namespace Traffic_Light_Simulator
{
    public class Zebra : IDrawable
    {
        public Rectangle HitBox { get; set; }
        public Image Image { get; set; }
        public Point Position { get; set; }
    }
}