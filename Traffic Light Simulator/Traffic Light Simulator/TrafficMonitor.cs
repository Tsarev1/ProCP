using System.Collections.Generic;

namespace Traffic_Light_Simulator
{
    public class TrafficMonitor
    {
        public IList<BaseCrossing> Crossings { get; set; }

        public void Save() { }
        public void Load() { }
        public void SaveAs() { }
        public void AddCrossing(BaseCrossing crossing) { }
        public void RemoveCrossing(BaseCrossing crossing) { }
        public void StartSimulation() { }
        public void StopSimulation() { }
    }
}