using PracticeDesignPatternBehavior.Interfaz;
using System;
using System.Collections.Generic;
using System.Text;

namespace PracticeDesignPatternBehavior.Class
{
    public class PrivateJet: Airplane
    {
        public ICommunication Communication;
        public override string ConnectionWithOtherAirplane(Airplane TypeAirplane)
        {
            return $"{base.ConnectionWithOtherAirplane(TypeAirplane)}Ready";
        }
        public string ConnectionToPassangerAirliner()
        {
            return $"Start the connection\n{this._communication.CommunicationBetween(this, "Connection")}";
        }

        public override string TypeAirplane()
        {
            return "Private Jet";
        }

        public override void TypeOfConnection(int NumberFrecuency)
        {
            Frecuency = NumberFrecuency;
        }
        public override string Help()
        {
            return _communication.CommunicationBetween(this,"Help");
        }
    }
}
