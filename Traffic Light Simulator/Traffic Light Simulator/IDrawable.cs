using System.Drawing;

namespace Traffic_Light_Simulator
{
    public interface IDrawable
    {
        Rectangle HitBox { get; set; }
        Image Image { get; set; }
        Point Position { get; set; }
    }
}