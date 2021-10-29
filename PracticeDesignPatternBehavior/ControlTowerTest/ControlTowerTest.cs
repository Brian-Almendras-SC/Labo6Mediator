using NUnit.Framework;
using PracticeDesignPatternBehavior.Class;

namespace ControlTowerTest
{
    public class Tests
    {
        ControlTower controlTower;
        PassangerAirlaner passangerAirlaner;
        Helicopter helicopter ;
        PrivateJet privateJet ;
        string VarAux;
        [SetUp]
        public void Setup()
        {
            passangerAirlaner = new PassangerAirlaner();
            helicopter = new Helicopter();
            privateJet = new PrivateJet();
            controlTower=new ControlTower(passangerAirlaner, privateJet, helicopter);
            passangerAirlaner.TypeOfConnection(100);
            privateJet.TypeOfConnection(101);
            helicopter.TypeOfConnection(1);
        }

        [Test]
        public void ConnectionWithPrivateJetThroughControlTower()
        {
            VarAux = "Start the connection\nConnect in frecuency 100\nType of Passanger Airlaner\nReady";
            Assert.AreEqual(passangerAirlaner.ConnectionToPrivateJet(), VarAux);
        }
        [Test]
        public void ConnectionWithPassangerAirlanerThroughControlTower()
        {
            VarAux = "Start the connection\nConnect in frecuency 101\nType of Private Jet\nReady";
            Assert.AreEqual(privateJet.ConnectionToPassangerAirliner(), VarAux);
        }
        [Test]
        public void PrivateJetSendingMesssageSos()
        {
            VarAux = "Sending Helicopter for you rescue";
            Assert.AreEqual(privateJet.Help(), VarAux);
        }
        [Test]
        public void PassangerAirlanerSendingMesssageSos()
        {
            VarAux = "Sending Helicopter for you rescue";
            Assert.AreEqual(privateJet.Help(), VarAux);
        }
        [Test]
        public void PassangerAirlanerConnectionToControlTower()
        {
            VarAux=controlTower.CommunicationBetween(passangerAirlaner,"Connection");
            Assert.AreEqual(VarAux, "Connect in frecuency 100\nType of Passanger Airlaner\nReady");
        }
        [Test]
        public void PrivateJetConnectionToControlTower()
        {
            VarAux = controlTower.CommunicationBetween(privateJet, "Connection");
            Assert.AreEqual(VarAux, "Connect in frecuency 101\nType of Private Jet\nReady");
        }
        [Test]
        public void PassangerAirlanerAskingForHelpToControlTower()
        {
            VarAux = controlTower.CommunicationBetween(passangerAirlaner, "Help");
            Assert.AreEqual(VarAux, "Sending Helicopter for you rescue");
        }
        [Test]
        public void PrivateJetAskingForHelpToControlTower()
        {
            VarAux = controlTower.CommunicationBetween(privateJet, "Help");
            Assert.AreEqual(VarAux, "Sending Helicopter for you rescue");
        }

        [Test]
        public void NotImplementedOtherOpcionsForConnectionWithControlTower()
        {
            VarAux = controlTower.CommunicationBetween(privateJet, "Arrive");
            Assert.AreEqual(VarAux, null);
        }
    }
}