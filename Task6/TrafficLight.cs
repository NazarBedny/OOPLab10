using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task6
{
    public class TrafficLight
    {
        private LightEnum _currentSignal;

        public TrafficLight(string signal)
        {
            _currentSignal = (LightEnum)Enum.Parse(typeof(LightEnum), signal);
        }

        private void UpdateColor()
        {
            int previous = (int)_currentSignal;

            _currentSignal = (LightEnum)(((int)_currentSignal + 1) % 3);
        }
    }

}
