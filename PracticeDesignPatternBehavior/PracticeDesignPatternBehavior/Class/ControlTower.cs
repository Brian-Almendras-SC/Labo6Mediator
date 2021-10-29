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

        public ControlTower(PassangerAirlaner PassangerAirlaner, PrivateJet PrivateJet, Helicopter Helicopter )
        {
            this._passangerAirlaner = PassangerAirlaner;
            this._passangerAirlaner.ConnetionToControlTower(this);
            this._privateJet = PrivateJet;
            this._privateJet.ConnetionToControlTower(this);
            _helicopter = Helicopter;
            _helicopter.ConnetionToControlTower(this);
        }
        public string CommunicationBetween(Airplane TypeAirplane, string Action)
        {
            if (Action=="Connection")
            {
                switch (TypeAirplane.TypeAirplane())
                {
                    case "Private Jet": return _privateJet.ConnectionWithOtherAirplane(_privateJet);
                    case "Passanger Airlaner": return _passangerAirlaner.ConnectionWithOtherAirplane(_passangerAirlaner);
                    default: return null;
                }
            }
            if (Action=="Help")
            {
                switch (TypeAirplane.TypeAirplane())
                {
                    case "Private Jet":
                    case "Passanger Airlaner": return _helicopter.Rescue();
                    default: return null;
                        
                }
            }
            return null;
        }
    }
}
