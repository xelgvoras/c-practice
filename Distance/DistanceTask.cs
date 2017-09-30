using System;

namespace DistanceTask
{
	public static class DistanceTask
	{
		// Расстояние от точки (x, y) до отрезка AB с координатами A(ax, ay), B(bx, by)
		public static double GetDistanceToSegment(double ax, double ay, double bx, double by, double x, double y)
		{
            var lengthAB = GetVectorLength(ax, ay, bx, by);
            var lengthAX = GetVectorLength(x, y, ax, ay);
            var lengthBX = GetVectorLength(x, y, bx, by);

            if (lengthAB == 0)
            {
                return lengthAX;
            }
            else if (HaveNormal(ax, ay, bx, by, x, y))
            {
                var distance = Math.Abs(((bx - ax) * (y - ay) - (by - ay) * (x - ax)) / lengthAB);
                return distance;
            }
            else
            {
                return Math.Min(lengthAX, lengthBX);
            }
		}

        private static double GetVectorLength (double x1, double y1, double x2, double y2)
        {
            var a = x1 - x2;
            var b = y1 - y2;
            var c = Math.Sqrt(Math.Pow(a, 2) + Math.Pow(b, 2));
            return c;
        }

        private static bool HaveNormal(double ax, double ay, double bx, double by, double x, double y)
        {
            var scalarAXtoAB = (x - ax) * (bx - ax) + (y - ay) * (by - ay);
            var scalarBXtoBA = (x - bx) * (ax - bx) + (y - by) * (ay - by);
            return scalarAXtoAB > 0 && scalarBXtoBA > 0;
        }
	}
}