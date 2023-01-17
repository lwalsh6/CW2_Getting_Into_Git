using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CW2
{
    class Program //Class name, can be changed
    {
        private int steve;

        public void setSteve(int s)
        {
            steve = s;
        }
        public int getSteve()
        {
            return steve;
        }

        static void Main(string[] args)
        {
            Program p = new Program();
            Console.WriteLine("Hello World!" + 5);
            Console.ReadKey();
            Console.WriteLine("Setting Steve to 4");
            p.setSteve(4);
            Console.WriteLine("Steve is: " + p.getSteve());
            Console.ReadKey();
        }
    }
}
