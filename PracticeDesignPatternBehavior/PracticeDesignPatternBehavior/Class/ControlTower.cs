using PracticeDesignPatternBehavior.Interfaz;
using System;
using System.Collections.Generic;
using System.Text;

namespace PracticeDesignPatternBehavior.Class
{
    public class ControlTower: ICommunication
    {
        private PassangerAirlaner _passangerAirlaner;
        private Helicopter _helicopter;
        private PrivateJet _privateJet;

        public ControlTower(PassangerAirlaner PassangerAirlaner, PrivateJet PrivateJet)
        {
            this._passangerAirlaner = PassangerAirlaner;
            this._passangerAirlaner.ConnetionToControlTower(this);
            this._privateJet = PrivateJet;
            this._privateJet.ConnetionToControlTower(this);
        }
        public string CommunicationBetween(Airplane TypeAirplane, string Action)
        {
            switch (Action)
            {
                case "PrivateJet": return _privateJet.ConnectionWithOtherAirplane(_privateJet);
                case "PassangerAirliner": return _passangerAirlaner.ConnectionWithOtherAirplane(_passangerAirlaner);
                default: return null;
            }
        }
    }
}
