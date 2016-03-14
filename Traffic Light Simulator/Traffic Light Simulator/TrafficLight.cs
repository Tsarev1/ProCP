using System.Drawing;

namespace Traffic_Light_Simulator
{
    public class TrafficLight : IDrawable
    {
        public Image Image { get; set; }
        public Rectangle HitBox { get; set; }
        public Point Position { get; set; }

        public TrafficLightColor TrafficColor { get; set; }

        public int GreenTime { get; set; }
        public int RedTime { get; set; }

        public bool StandBy { get; }//a better name probably
        public Lane AttachedLane { get; set; }
        public Sensor Sensor { get; set; }

        public void SwitchLight(TrafficLightColor color) { }
        public void Disable() { }
        public void ChangeBehaviour() { }

    }
}