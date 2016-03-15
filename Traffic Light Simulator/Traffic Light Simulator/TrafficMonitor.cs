using System.Collections.Generic;

namespace Traffic_Light_Simulator
{
    public class TrafficMonitor
    {
        public IList<BaseCrossing> Crossings { get; set; }

        public void Save() { }
        public void Load() { }
        public void SaveAs() { }
        public bool AddCrossing(BaseCrossing crossing) { return true; }
        public bool RemoveCrossing(BaseCrossing crossing) { return true; }
        public void StartSimulation() { }
        public void StopSimulation() { }
    }
}