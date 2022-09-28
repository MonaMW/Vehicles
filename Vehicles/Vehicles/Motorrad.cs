using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Vehicles
{
    public class Motorrad : Vehicles
    {
        public Motorrad()
        {
        }

        public Motorrad(string hersteller, int typeId, int geschwindigkeit, string color, int fußpedal)
        {
            Hersteller = hersteller;
            TypeId = typeId;
            Geschwindigkeit = geschwindigkeit;
            Color = color;
            Fußpedal = fußpedal;
        }

        public void MotorradInfo()
        {
            Console.WriteLine("Von welchem Hersteller soll das Motorrad sein?");
            Hersteller = Console.ReadLine();
            Console.WriteLine("Welche Id soll das Motorrad haben?");
            TypeId = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Mit welcher Geschwindikeit soll das Motorrad fahren?");
            Geschwindigkeit = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Welche Farbe soll das Motorrad haben?");
            Color = Console.ReadLine();
            Console.WriteLine($"Die Farbe des Motorrads ist {Color}.");
        }

        public void Bremsen()
        {
            Geschwindigkeit--;
            Console.WriteLine($"Die Geschwindigkeit beträgt {Geschwindigkeit}.");
        }
    }
}
