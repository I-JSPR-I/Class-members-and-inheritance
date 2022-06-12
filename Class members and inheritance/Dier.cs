using System;
using System.Collections.Generic;
using System.Text;

namespace Class_members_and_inheritance
{
    class Dier
    {
        public void Eet()
        {
            Console.WriteLine("Ik eet graag");
        }
        public void Eet(int nummer)
        {
            Console.WriteLine($"Ik eet graag {nummer} kg hooi");
        }
        public void Stap()
        {
            Console.WriteLine("Ik stap snel");
        }
    }
}
