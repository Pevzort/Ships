using System;
using System.Collections.Generic;
using System.Text;

namespace Ships
{
    class ShipList
    {
        static public ShipList Load(string filename)
        {
            ShipList list = new ShipList();
            try
            {
                using (System.IO.StreamReader sr = new System.IO.StreamReader(filename))
                {
                    string line;

                    while ((line = sr.ReadLine()) != null)
                    {
                        string[] data = line.Split('|');
                        string[] dataPoint = data[1].Split('x');
                        Ship ship = new Ship(data[0], new System.Drawing.Point(Convert.ToInt32(dataPoint[0]), Convert.ToInt32(dataPoint[1])), data[2]);
                        list.Add(ship);
                    }
                }
            }
            catch (Exception e)
            {
                Console.WriteLine("Exception: " + e.Message);
            }
            return list;
        }
        public void Add(Ship ship)
        {
            _shipList.Add(ship);
        }

        public ShipList Select(Rect rect, ShipType shipType)
        {
            ShipList list = new ShipList();
            foreach (Ship ship in _shipList)
            {
                if (ship.isInRect(rect) && shipType.isEquals(ship.Type))
                {
                    list.Add(ship);
                }
            }
            return list;
        }
        public void Print()
        {
            _shipList.ForEach((Ship ship) =>
            {
                ship.Print();
            });
        }
        public int Count { get { return _shipList.Count; } }

        private List<Ship> _shipList = new List<Ship>();
    }
}
