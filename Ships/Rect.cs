using System;
using System.Collections.Generic;
using System.Drawing;
using System.Text;

namespace Ships
{
    class Rect
    {
        static public Rect ReadFromKbd() {
            Rect rect = new Rect();
            string[] lineData = Console.ReadLine().Split("|");
            string[] leftTop = lineData[0].Split('x');
            string[] rightBottom= lineData[1].Split('x');

            rect._leftTop = new Point(Convert.ToInt32(leftTop[0]), Convert.ToInt32(leftTop[1]));
            rect._rightBottom = new Point(Convert.ToInt32(rightBottom[0]), Convert.ToInt32(rightBottom[1]));

            return rect;
        }
        public bool Inside(Point point) {
            bool isLocatedX = point.X > _leftTop.X && point.X < _rightBottom.X;
            bool isLocatedY = point.Y < _leftTop.Y && point.Y > _rightBottom.Y;

            return isLocatedX && isLocatedY;
        }

        private Point _leftTop;
        private Point _rightBottom;
    }
}
