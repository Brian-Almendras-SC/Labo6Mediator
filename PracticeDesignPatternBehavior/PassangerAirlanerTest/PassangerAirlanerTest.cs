using NUnit.Framework;
using PracticeDesignPatternBehavior.Class;

namespace PassangerAirlanerTest
{
    public class Tests
    {
        PassangerAirlaner passangerAirlaner;
        string VarAux;
        [SetUp]
        public void Setup()
        {
            passangerAirlaner = new PassangerAirlaner();
            passangerAirlaner.TypeOfConnection(101);
        }

        [Test]
        public void AssignValueToFrecuencyForPrivateJet()
        {
            Assert.AreEqual(passangerAirlaner.Frecuency, 101);
        }
        [Test]
        public void ReturnTypeOfAirplaneInStringFormat()
        {
            Assert.AreEqual(passangerAirlaner.TypeAirplane(), "Passanger Airlaner");
        }
        [Test]
        public void ConnectionWithOtherAirplane()
        {
            VarAux = "Connect in frecuency 101\nType of Private Jet\nReady";
            Assert.AreEqual(passangerAirlaner.ConnectionWithOtherAirplane(new PrivateJet()), VarAux);
        }
    }
}