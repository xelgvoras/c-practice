﻿using System;

namespace AngryBirds
{
	public static class AngryBirdsTask
	{
		//  Ниже — это XML документация, её использует ваша среда разработки, 
		// чтобы показывать подсказки по использованию методов. 
		// Но писать её естественно не обязательно.
		/// <param name="v">Начальная скорость</param>
		/// <param name="distance">Расстояние до цели</param>
		/// <returns>Угол прицеливания в радианах от 0 до Pi/2</returns>
		public static double FindSightAngle(double v, double distance)
		{
            const double g = 9.8;
            var alpha = 0.0;
            alpha = Math.Asin((distance * g) / Math.Pow(v, 2)) / 2;
            return alpha;
		}
	}
}