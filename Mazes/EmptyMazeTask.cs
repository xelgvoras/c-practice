namespace Mazes
{
	public static class EmptyMazeTask
	{
		public static void MoveOut(Robot robot, int width, int height)
		{
            GoToX(robot, width);
            GoToY(robot, height);
		}

        private static void GoToX(Robot robot, int coords)
        {
            while (robot.X != (coords - 2))
                robot.MoveTo(Direction.Right);
        }

        private static void GoToY(Robot robot, int coords)
        {
            while (robot.Y != (coords - 2))
                robot.MoveTo(Direction.Down);
        }
	}
}