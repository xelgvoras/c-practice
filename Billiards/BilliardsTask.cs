using System;

namespace Billiards
{
	public static class BilliardsTask
	{
		public static double BounceWall(double directionRadians, double wallInclinationRadians)
		{
            //TODO
            var normal = wallInclinationRadians + Math.PI / 2;
            var angleIncidence = wallInclinationRadians - directionRadians;
            var angleReflection = Math.PI / 2 - angleIncidence;
            var angleRotation = normal - angleReflection;
			return angleRotation;
		}
	}
}