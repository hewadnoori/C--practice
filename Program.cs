//to make the c# environment, run dotnet new console
//to run the program, run dotnet run

using System;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            string name = "John";
            Console.WriteLine("Hello World!" + name);

            Humanoid humanoid = new Humanoid();
            humanoid.Name = "jimmmy";
            Console.WriteLine(humanoid.Name);
            Humanoid humanoid2 = new Humanoid();
            humanoid2.Name = "jimmmy2";
            Console.WriteLine(humanoid2.Name);
        }
    }
}
