using System;
using System.Collections.Generic;

namespace IceCreamShop
{
    class Program
    {
        static void Main(string[] args)
        {
            Case menu = new Case();
            List<Flavor> availableFlavors = menu.Flavors;
            List<Cone> availableCones = menu.Cones;

            Console.WriteLine("Flavors before: ");
            foreach (Flavor f in availableFlavors)
            {
                Console.WriteLine(f.Name);
            }
            Console.WriteLine();

            availableFlavors.Sort(new FlavorComparer());

            Console.WriteLine("Flavors after: ");
            foreach (Flavor f in availableFlavors)
            {
                Console.WriteLine(f.Name);
            }
            Console.WriteLine();


            Console.WriteLine("Cones before: ");
            foreach (Cone c in availableCones)
            {
                Console.WriteLine(c.Name + ": $" + c.Cost);
            }
            Console.WriteLine();

            availableCones.Sort(new ConeComparer());

            Console.WriteLine("Cones after: ");
            foreach (Cone c in availableCones)
            {
                Console.WriteLine(c.Name + ": $" + c.Cost);
            }
            Console.WriteLine();
        }
    }
}
