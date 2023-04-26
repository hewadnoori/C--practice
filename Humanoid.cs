using System;

namespace ConsoleApp1
{
    class Humanoid
    {
        public string? Name { get; set; }

        //constructor
        public Humanoid()
        {
            Console.WriteLine("I'm a humanoid!");
        }

        //destructor
        ~Humanoid()
        {
            Console.WriteLine("I'm in heaven now!");
        }
    }
}
