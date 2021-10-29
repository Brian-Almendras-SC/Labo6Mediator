using NUnit.Framework;
using PracticeDesignPatternBehavior.Class;

namespace HelicopterTest
{
    public class Tests
    {
        Helicopter helicopter;
        string VarAux;
        [SetUp]
        public void Setup()
        {
            helicopter = new Helicopter();
        }
        [Test]
        public void TypeOfHelicopter()
        {
            VarAux = "Helicopter";
            Assert.AreEqual(helicopter.TypeAirplane(), VarAux);
        }
        [Test]
        public void MessageOfRescue()
        {
            VarAux = "Sending Helicopter for you rescue";
            Assert.AreEqual(helicopter.Rescue(),VarAux);
        }
    }
}