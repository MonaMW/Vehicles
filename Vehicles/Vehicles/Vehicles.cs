using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Vehicles
{
    public abstract class Vehicles
    {
        public string Hersteller { get; set; }
        public int TypeId { get; set; }
        public string Color { get; set; }
        public int Geschwindigkeit { get; set; }
        public int Fußpedal { get; set; }
        public bool MotorLaeuft { get; set; }
        public int AnzahlAnhaenger { get; set; }

        public void Beschleunigen()
        {
            Geschwindigkeit += 10;
        }
    }
}
