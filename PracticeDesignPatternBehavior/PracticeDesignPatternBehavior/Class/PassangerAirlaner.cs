using PracticeDesignPatternBehavior.Interfaz;
using System;
using System.Collections.Generic;
using System.Text;

namespace PracticeDesignPatternBehavior.Class
{
    public class PassangerAirlaner : Airplane
    {

        public override string ConnectionWithOtherAirplane(Airplane TypeAirplane)
        {
            return $"{base.ConnectionWithOtherAirplane(TypeAirplane)}Ready";
        }
        public string  ConnectionToPrivateJet()
        {
            return  $"Start the connection\n{this._communication.CommunicationBetween(this, "Connection")}";
        }

        public override string TypeAirplane()
        {
            return "Passanger Airlaner";
        }

        public override void TypeOfConnection(int NumberFrecuency )
        {
            Frecuency = NumberFrecuency;
        }

        public override string Help()
        {
            return $"{base.Help()}{ _communication.CommunicationBetween(this, "Help")}";
        }
    }
}
