using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    class Program
    {
        static void Main(){
          
            List<Killer> robots = new List<Killer>();
            robots.Add(new Killer("Alex", 400, new byte[] { 0, 0, 10 },100));
            robots.Add(new Killer("Bob", 600, new byte[] { 0, 10, 10 }, 100));
            robots.Add(new Killer("John", 800, new byte[] { 10, 0, 10 }, 100));
            robots.Add(new Killer("Josh", 600, new byte[] { 0, 50, 10 }, 100));

            Robot newRobot = null;

            foreach(Killer obj in robots){
                if(obj.Name == "John"){
                    newRobot = obj as Robot;
                 }
            Console.WriteLine(obj is Robot);
                
            }
        }
    }
}

