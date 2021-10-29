using PracticeDesignPatternBehavior.Class;
using System;

namespace PracticeDesignPatternBehavior
{
    class Program
    {
        static void Main(string[] args)
        {
            PassangerAirlaner a = new PassangerAirlaner();
            PrivateJet c = new PrivateJet();

            new ControlTower(a,c);
            a.TypeOfConnection(100);
            c.TypeOfConnection(101);
            Console.WriteLine(a.ConnectionToPrivateJet());
            Console.WriteLine(c.ConnectionToPassangerAirliner());
            Console.WriteLine("Hello World!");
        }
    }
}
