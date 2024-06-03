using System;
using System.Collections.Generic;
using System.Text;

namespace I_am_all_alone
{
    public struct Point
    {
        public Point(int x, int y)
        {
            X = x;
            Y = y;
        }

        public int X { get; set; }
        public int Y { get; set; }
    }

    public class Dinglemouse
    {
        public static bool AllAlone(char[][] house)
        {
            Point potus = default;

            for (int i = 0; i < house.GetLength(0); i++)
            {
                for (int j = 0; j < house[i].Length; j++)
                {
                    if (house[i][j] == 'X')
                    {
                        potus = new Point(i, j);    
                    }
                }
            }

            var scanPoints = new List<Point>();

            var isNotAlone = Scan(potus, house, scanPoints);

            return !isNotAlone;
        }

        public static bool Scan(Point point, char[][] house, List<Point> scanedPoints)
        {
            if (scanedPoints.Contains(point))
            {
                return false;
            }
            scanedPoints.Add(point);

            if(house[point.X][point.Y] == 'o')
            {
                return true;
            }

            if (house[point.X][point.Y] == '#')
            {
                return false;
            }

            var pointUp = new Point(point.X, point.Y - 1);
            var pointDown = new Point(point.X, point.Y + 1);
            var pointLeft = new Point(point.X - 1, point.Y);
            var pointRight = new Point(point.X + 1, point.Y);

            return Scan(pointUp, house, scanedPoints) ||
                   Scan(pointDown, house, scanedPoints) ||
                   Scan(pointLeft, house, scanedPoints) ||
                   Scan(pointRight, house, scanedPoints);
        }
    }
}
