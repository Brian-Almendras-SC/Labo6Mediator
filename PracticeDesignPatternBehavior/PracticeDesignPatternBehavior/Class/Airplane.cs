using PracticeDesignPatternBehavior.Interfaz;
using System;
using System.Collections.Generic;
using System.Text;

namespace PracticeDesignPatternBehavior.Class
{
    public abstract class Airplane
    {
        private int _frecuency;
        public int Frecuency {
            set { _frecuency = value; }
            get { return _frecuency; }
        }
        protected ICommunication _communication;
        public void ConnetionToControlTower(ICommunication Communication)
        {
            this._communication = Communication;
        }
        public virtual string ConnectionWithOtherAirplane(Airplane TypeAirplane) 
        {
            return $"Connect in frecuency {_frecuency}\nType of {TypeAirplane.TypeAirplane()}\n";
        }
        public virtual string Help()
        {
            return "Connection with Control Tower\nSend:S.O.S\n";
        }
        public abstract void TypeOfConnection(int NumberFrecuency);
        public abstract string TypeAirplane();
    }
}
