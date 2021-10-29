using PracticeDesignPatternBehavior.Class;
using System;

namespace PracticeDesignPatternBehavior
{
    class Program
    {
        static void Main(string[] args)
        {
            PassangerAirlaner passangerAirlaner  = new PassangerAirlaner();
            Helicopter helicopter = new Helicopter();
            PrivateJet privateJet = new PrivateJet();

            new ControlTower(passangerAirlaner, privateJet,helicopter);
            passangerAirlaner.TypeOfConnection(100);
            privateJet.TypeOfConnection(101);
            Console.WriteLine(passangerAirlaner.ConnectionToPrivateJet());
            Console.WriteLine(privateJet.ConnectionToPassangerAirliner());

            Console.WriteLine(passangerAirlaner.Help());
        }
    }
}
