using System;

namespace Ships
{
    class Program
    {
        static void Main(string[] args)
        {
            ShipList shipList = ShipList.Load("../../../data/ships.txt");
            Console.WriteLine("Задайте регион поиска: вверхня точка|нижняя точка");
            Rect rect = Rect.ReadFromKbd();

            Console.WriteLine("Задайте тип корабля для поиска: пассажирский, грузовой, боевой");
            string type = Console.ReadLine();
            ShipType searchType = ShipType.ToShipType(type);

            ShipList resultList = shipList.Select(rect, searchType);
            PrintResult(resultList);
        }
        static void PrintResult(ShipList list)
        {
            Console.WriteLine($"В заданном регионе найдено кораблей - {list.Count}.");
            list.Print();
        }

    }
}
