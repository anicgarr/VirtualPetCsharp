using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VirtualPet
{
    class VirtualPet
    {
        public string name { get; set; }
   
        public int hunger { get; set; } = 50;
        public int energy { get; set; } = 50;
        public int thirst { get; set; } = 50;



        public void tick()
        {
            hunger += 2;
            energy -= 2;
            thirst += 2;

        }
        public VirtualPet(string name, int hunger, int energy, int thirst)
        {

        }

        public void feedPet()
        {
            this.hunger = -5;
            this.thirst = +5;
        }
        public void giveWater()
        {
            this.thirst = -5;
        }
        public void layDownForNap()
        {
            this.energy = +5;
        }
    }




}

