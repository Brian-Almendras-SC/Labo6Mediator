using PracticeDesignPatternBehavior.Interfaz;
using System;
using System.Collections.Generic;
using System.Text;

namespace PracticeDesignPatternBehavior.Class
{
    public class Helicopter : Airplane
    {
        public string Rescue()
        {
            return $"Sending {this.TypeAirplane()} for you rescue";
        }
        public override string Help()
        {
            return _communication.CommunicationBetween(this, "Help");
        }

        public override string TypeAirplane()
        {
            return "Helicopter";
        }

        public override void TypeOfConnection(int NumberFrecuency)
        {
            this.Frecuency = NumberFrecuency;
        }
    }
}
