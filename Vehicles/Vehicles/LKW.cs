using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Vehicles
{
    public class LKW : Vehicles
    {
        public LKW()
        {
        }

        public LKW(string hersteller, int typeId, int geschwindigkeit, int anzahlAnhaenger)
        {
            Hersteller = hersteller;
            TypeId = typeId;
            Geschwindigkeit = geschwindigkeit;
            AnzahlAnhaenger = anzahlAnhaenger;
        }

        public void LKWInfo()
        {
            Console.WriteLine("Von welchem Hersteller soll der LKW sein?");
            Hersteller = Console.ReadLine();
            Console.WriteLine("Welche Id soll der LKW haben?");
            TypeId = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Mit welcher Geschwindikeit soll der LKW fahren?");
            Geschwindigkeit = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine($"Der Hersteller des LKWs ist {Hersteller} und die Id des LKWs ist {TypeId}. Er fährt mit einer Geschwindigkeit von {Geschwindigkeit}.");
        }

        public void Anhaenger()
        {
            Console.WriteLine("Wie viele Anhänger sollen angehängt werden?");
            AnzahlAnhaenger = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine($"{AnzahlAnhaenger} Anhänger wurden angehängt.");
        }
    }
}
