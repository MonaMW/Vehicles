using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Vehicles
{
    public class PKW : Vehicles
    {
        public PKW()
        {
        }

        public PKW(string hersteller, int typeId, int geschwindigkeit, bool motorlaeuft)
        {
            Hersteller = hersteller;
            TypeId = typeId;
            Geschwindigkeit = geschwindigkeit;
            MotorLaeuft = motorlaeuft;
        }

        public void PKWInfo()
        {
            Console.WriteLine("Von welchem Hersteller soll das Auto sein?");
            Hersteller = Console.ReadLine();
            Console.WriteLine("Welche Id soll das Auto haben?");
            TypeId = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Mit welcher Geschwindikeit soll das Auto fahren?");
            Geschwindigkeit = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine($"Der Hersteller des Autos ist {Hersteller} und die Id ist {TypeId}. Es fährt mit {Geschwindigkeit}km/h.");
        }

        public void Starten()
        {
            if (MotorLaeuft)
            {
                Console.WriteLine("Motor läuft schon, kann ihn nicht starten!");
            }
            else
            {
                MotorLaeuft = true;
                Console.WriteLine("Motor wird gestartet!");
            }
        }
    }
}
