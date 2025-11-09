using System;

namespace VacuumApp
{
    class VacuumCleaner
    {
        // ---------- Attributes ----------
        public string Brand { get; set; }      // Brand name
        public int Power { get; set; }         // Power in watts
        public string Color { get; set; }      // Color
        public int Capacity { get; set; }      // Capacity in liters
        public bool IsOn { get; private set; } // On/Off status

        // ---------- Constructor ----------
        public VacuumCleaner(string brand, int power, string color, int capacity)
        {
            Brand = brand;
            Power = power;
            Color = color;
            Capacity = capacity;
            IsOn = false;
        }

        // ---------- Methods ----------
        public void TurnOn()
        {
            if (!IsOn)
            {
                IsOn = true;
                Console.WriteLine(Brand + " is now ON. Power: " + Power + "W");
            }
            else
            {
                Console.WriteLine(Brand + " is already ON!");
            }
        }

        public void TurnOff()
        {
            if (IsOn)
            {
                IsOn = false;
                Console.WriteLine(Brand + " is now OFF.");
            }
            else
            {
                Console.WriteLine(Brand + " is already OFF!");
            }
        }

        public void Clean()
        {
            if (IsOn)
            {
                Console.WriteLine(Brand + " is cleaning the floor...");
            }
            else
            {
                Console.WriteLine("Please turn on the vacuum cleaner first!");
            }
        }

        public void ShowStatus()
        {
            Console.WriteLine("------ Vacuum Status ------");
            Console.WriteLine("Brand: " + Brand);
            Console.WriteLine("Power: " + Power + "W");
            Console.WriteLine("Color: " + Color);
            Console.WriteLine("Capacity: " + Capacity + "L");
            Console.WriteLine("Is On? " + (IsOn ? "Yes" : "No"));
            Console.WriteLine("---------------------------");
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            // Create a few vacuum cleaner objects
            VacuumCleaner v1 = new VacuumCleaner("Philips", 1800, "Silver", 3);
            VacuumCleaner v2 = new VacuumCleaner("Samsung", 2000, "Black", 4);
            VacuumCleaner v3 = new VacuumCleaner("Bosch", 2200, "Red", 5);

            // Use the methods
            v1.ShowStatus();
            v1.TurnOn();
            v1.Clean();
            v1.TurnOff();

            Console.WriteLine();
            v2.ShowStatus();
            v3.ShowStatus();

            Console.WriteLine("Program finished. Press any key to exit...");
            Console.ReadKey();
        }
    }
}
