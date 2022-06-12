using System;

namespace Class_members_and_inheritance
{
    class Program
    {
        static void Main(string[] args)
        {
            Dier animal = new Dier();
            Paard horse = new Paard();
            int test=0;
            animal.Eet(test);
            animal.Eet();
            animal.Stap();
            horse.hallop();
        }
    }
}
