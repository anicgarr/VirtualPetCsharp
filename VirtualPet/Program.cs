using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VirtualPet;

namespace VirtualPet
{
    class VirtualPetApp
    {
        static void Main(string[] args)
        {
            string name = null;
            int desiredAction = 0;

            VirtualPet yourPet = new VirtualPet(name, 50, 50, 50);

            Console.WriteLine("Welcome to your Virtual Pet!");
           Console.WriteLine("What would you like to name your pet?");
            yourPet.name = Console.ReadLine();

            Console.WriteLine("What would you like to do with " + yourPet.name + "?");
            Console.WriteLine("Enter 1 to feed ");
            Console.WriteLine("2 to give water");
            Console.WriteLine("3 to put down for a nap");
            Console.WriteLine("4 to get current stats");

            do
            {
                yourPet.tick();
                Console.WriteLine("What does " + yourPet.name + " need now?");
                desiredAction = Convert.ToInt32(Console.ReadLine());

                if (yourPet.energy < 0)
                {
                    Console.WriteLine("You've neglected your pet. Energy is too low. Game Over");
                    Console.WriteLine("Look at what you did to poor " + yourPet.name + "!");
                    Console.WriteLine("Hunger:" + yourPet.hunger);
                    Console.WriteLine("Thirst:" + yourPet.thirst);
                    Console.WriteLine("Energy:" + yourPet.energy);
                    Environment.Exit(0);
                }
                if (yourPet.hunger > 100)
                {
                    Console.WriteLine("You've neglected your pet." + yourPet.name + "is starving. Game Over.");
                    Console.WriteLine("Look at what you did to poor " + yourPet.name + "!");
                    Console.WriteLine("Hunger:" + yourPet.hunger);
                    Console.WriteLine("Thirst:" + yourPet.thirst);
                    Console.WriteLine("Energy:" + yourPet.energy);
                    Environment.Exit(0);
                }
                if (yourPet.thirst > 100)
                {
                    Console.WriteLine("You've neglected your pet." + yourPet.name + "is dying of starvation. Game Over");
                    Console.WriteLine("Look at what you did to poor " + yourPet.name + "!");
                    Console.WriteLine("Hunger:" + yourPet.hunger);
                    Console.WriteLine("Thirst:" + yourPet.thirst);
                    Console.WriteLine("Energy:" + yourPet.energy);
                    Environment.Exit(0);
                }

                if (desiredAction == 1)
                {
                    yourPet.feedPet();
                    Console.WriteLine("Your pet is eating...");

                }
                else if (desiredAction == 2)
                {
                    yourPet.giveWater();
                    Console.WriteLine("Your pet is drinking water...");

                }
                else if (desiredAction == 3)
                {
                    yourPet.layDownForNap();
                    Console.WriteLine("Great job! Your pet is taking a nap...");
                }
                else if (desiredAction == 4)
                {
                    Console.WriteLine("Here are " + yourPet.name + "'s current stats!");
                    Console.WriteLine("Hunger:" + yourPet.hunger);
                    Console.WriteLine("Thirst:" + yourPet.thirst);
                    Console.WriteLine("Energy:" + yourPet.energy);

                }
                else
                {
                    Console.WriteLine("That's not a valid choice. Try Again.");
                }

            } while (true);
        }
    }


}
    

