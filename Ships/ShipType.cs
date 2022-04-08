using System;
using System.Collections.Generic;
using System.Text;

namespace Ships
{
    class ShipType
    {
        public enum ShipTypes
        {
            Passenger,
            Cargo,
            Military,
            Unknown
        }

        static public ShipType ToShipType(string type)
        {
            ShipType shipType = new ShipType();
            if (type.IndexOf("пас") != -1)
            {
                shipType.SetShipType(ShipTypes.Passenger);
                return shipType;
            }
            if (type.IndexOf("гр") != -1)
            {
                shipType.SetShipType(ShipTypes.Cargo);
                return shipType;
            }
            if (type.IndexOf("бое") != -1)
            {
                shipType.SetShipType(ShipTypes.Military);
                return shipType;
            }
            shipType.SetShipType(ShipTypes.Unknown);
            return shipType;
        }
        public bool isEquals(ShipType shipType)
        {
            return _shipType.Equals(shipType.Type); 
        }

        public ShipTypes Type { get { return _shipType; } }

        private void SetShipType(ShipTypes type)
        {
            _shipType = type;
        }
        private ShipTypes _shipType;
    }
}
