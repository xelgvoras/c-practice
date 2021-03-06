﻿using System;

namespace Rectangles
{
	public static class RectanglesTask
	{
		// Пересекаются ли два прямоугольника (пересечение только по границе также считается пересечением)
		public static bool AreIntersected(Rectangle r1, Rectangle r2)
		{
			// так можно обратиться к координатам левого верхнего угла первого прямоугольника: r1.Left, r1.Top
            for (var i = r2.Top; i <= r2.Bottom; i++)
            {
                if (i >= r1.Top && i <= r1.Bottom)
                {
                    for (var j = r2.Left; j <= r2.Right; j++)
                    {
                        if (j >= r1.Left && j <= r1.Right)
                            return true;
                    }
                }
            }
			return false;
		}

		// Площадь пересечения прямоугольников
		public static int IntersectionSquare(Rectangle r1, Rectangle r2)
		{
            if (AreIntersected(r1, r2))
            {
                var height = Math.Min(r1.Bottom, r2.Bottom) - Math.Max(r1.Top, r2.Top);
                var width = Math.Min(r1.Right, r2.Right) - Math.Max(r1.Left, r2.Left);
                var square = height * width;
                return square;
            }
            return 0;
		}

		// Если один из прямоугольников целиком находится внутри другого — вернуть номер (с нуля) внутреннего.
		// Иначе вернуть -1
		public static int IndexOfInnerRectangle(Rectangle r1, Rectangle r2)
		{
            if (r1.Left >= r2.Left && r1.Right <= r2.Right)
            {
                if (r1.Top >= r2.Top && r1.Bottom <= r2.Bottom)
                {
                    return 0;
                }
            }
            if (r2.Left >= r1.Left && r2.Right <= r1.Right)
            {
                if (r2.Top >= r1.Top && r2.Bottom <= r1.Bottom)
                {
                    return 1;
                }
            }
            return -1;
		}
	}
}