using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Traffic_Light_Simulator
{
    public abstract class BaseCrossing : IDrawable
    {
        public int ID { get; set; }
        public IList<BaseCrossing> Neighbours { get; set; }
        
        public Rectangle HitBox { get; set; }
        public Image Image { get; set; }
        public Point Position { get; set; }

        public void AddComponent() { }
        public void RemoveComponent() { }
    }
}