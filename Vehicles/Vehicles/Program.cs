using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Vehicles
{
    internal class Program
    {
        static void Main(string[] args)
        {
            PKW pkw = new PKW();
            LKW lkw = new LKW();
            Motorrad motorrad = new Motorrad();
            Vehicles vehicles = new PKW();

            pkw.PKWInfo();
            Console.WriteLine(" ");
            lkw.LKWInfo();
            Console.WriteLine(" ");
            motorrad.MotorradInfo();

            Console.WriteLine(" ");

            Console.WriteLine("Soll das Fahrzeug beschleunigen? (y/n)");
            string answer = Console.ReadLine();

            if (answer == "y")
            {
                vehicles.Beschleunigen();
                Console.WriteLine("Fahrzeug beschleunigt.");
            }

            Console.WriteLine(" ");

            Console.WriteLine("Motor starten?");
            motorrad.MotorLaeuft = Convert.ToBoolean(Console.ReadLine());
            pkw.Starten();

            Console.WriteLine(" ");

            Console.WriteLine("Motorrad bremsen?");
            string answer2 = Console.ReadLine();
            if (answer2 == "y")
                motorrad.Bremsen();

            Console.WriteLine(" ");

            lkw.Anhaenger();


            Console.ReadLine();
        }
    }
}
