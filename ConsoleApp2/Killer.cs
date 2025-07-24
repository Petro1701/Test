using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    class Killer : Robot
    {
        public int Health { get; set; }

        public void Lazer()
        {
            Console.WriteLine("Lazer shooting");
            base.surname = "Do";
        }
        public Killer(string name, int weight, byte[] coordinates, int health) : base(name, weight, coordinates)
        {
            this.Health = health;
            //base.PrintValues();
        }
    }
}

