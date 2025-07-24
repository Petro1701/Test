using System;
using System.CodeDom;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    class Robot
    {
        protected string surname;
        private static byte count = 0;
        private string name;
        private byte[] coordinates;
        private int weight;

        public string Name{
            get{
                return name;
            }
            private set{}
        }
        
        public int Weight{
            get{
                Console.Write("Результат: ");
                return this.weight;
            }
            set{
                if (value < 1)
                    this.weight = 1;
                else if (value > 5000)
                    this.weight = 5000;
                else
                    this.weight = value;
            }
        }


        public void setValues(string name, int weight, byte[] coordinates){
            this.name = name;
            this.weight = weight;
            this.coordinates = coordinates;
        }
        public Robot(string name, int weight, byte[] coordinates){
            Console.WriteLine("Object has been created!");
            this.setValues(name, weight, coordinates);
            count++;
        }
        public Robot() {
            count++;
        }

        public Robot(string name)
        {
            Console.WriteLine("Object has been created!");
            this.name = name;
            count++;
        }
     

      

        public void PrintValues()
        {
            Console.WriteLine(this.name+" weight: "+this.weight+" Coordinates: ");
            foreach(byte i in this.coordinates)
                Console.Write(i+":");
            Console.WriteLine();
        }

        public static void Print() {
            Console.WriteLine("Objects has been created: "+count);
        }

    }
}
