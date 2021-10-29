using PracticeDesignPatternBehavior.Class;
using System;
using System.Collections.Generic;
using System.Text;

namespace PracticeDesignPatternBehavior.Interfaz
{
    public interface ICommunication
    {
         abstract string CommunicationBetween(Airplane TypeAirplane, string Action);
    }
}
