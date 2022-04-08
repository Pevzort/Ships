using System;
using System.Collections.Generic;
using System.Drawing;
using System.Text;

namespace Ships
{
    class Ship
    {
        public Ship (string name, Point position, string type)
        {
            _name = name;
            _position = position;
            _type = ShipType.ToShipType(type);
        }
        public bool isInRect(Rect rect) {
            return rect.Inside(_position);
        }
        public void Print() {
            Console.WriteLine($"{_name}, {_position.ToString()}, {_type.Type.ToString("g")}");
        }
        public ShipType Type { get { return _type; } }

        private string _name;
        private Point _position;
        private ShipType _type;
    }
}
