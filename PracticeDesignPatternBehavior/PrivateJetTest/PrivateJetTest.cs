using NUnit.Framework;
using PracticeDesignPatternBehavior.Class;

namespace PrivateJetTest
{
    public class Tests
    {
        PrivateJet privateJet;
        string VarAux;
        [SetUp]
        public void Setup()
        {
            privateJet = new PrivateJet();
        }

        [Test]
        public void AssignValueToFrecuencyForPrivateJet()
        {
            privateJet.TypeOfConnection(100);
            Assert.AreEqual(privateJet.Frecuency,100);
        }
        [Test]
        public void ReturnTypeOfAirplaneInStringFormat()
        {
            Assert.AreEqual(privateJet.TypeAirplane(), "Private Jet");
        }
        [Test]
        public void ConnectionWithOtherAirplane()
        {
            VarAux = "Connect in frecuency 0\nType of Passanger Airlaner\nReady";
            Assert.AreEqual(privateJet.ConnectionWithOtherAirplane(new PassangerAirlaner()),VarAux);
        }
    }
}