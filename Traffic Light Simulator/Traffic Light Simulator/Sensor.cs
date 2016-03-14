namespace Traffic_Light_Simulator
{
    public abstract class Sensor
    {
        public int Range { get; set; }
        public Lane AttachedLane { get; set; }
        public TrafficLight TrafficLight { get; set; }
        public abstract void Scan(Lane laneToScan);
    }
}