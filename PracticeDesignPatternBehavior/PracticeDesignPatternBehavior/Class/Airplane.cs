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
        }
        protected ICommunication _communication;

        /*public Airplane(ICommunication Communication=null)
        {
            this._communication = Communication;
        }*/
        public void ConnetionToControlTower(ICommunication Communication)
        {
            this._communication = Communication;
        }
        public virtual string ConnectionWithOtherAirplane(Airplane TypeAirplane) 
        {
            return $"Connect in frecuency {_frecuency}\nType of {TypeAirplane.TypeAirplane()}\n";
        }
        public abstract void TypeOfConnection(int NumberFrecuency);
        public abstract string TypeAirplane();
    }
}
