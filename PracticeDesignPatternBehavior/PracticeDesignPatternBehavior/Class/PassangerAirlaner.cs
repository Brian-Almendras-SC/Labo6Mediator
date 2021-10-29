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
            return  $"Start the connection\n{this._communication.CommunicationBetween(this, "PrivateJet")}";
        }

        public override string TypeAirplane()
        {
            return "Passanger Airlaner";
        }

        public override void TypeOfConnection(int NumberFrecuency )
        {
            Frecuency = NumberFrecuency;
        }
    }
}
