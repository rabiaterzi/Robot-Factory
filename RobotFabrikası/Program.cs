using System;

namespace RobotFabrikası
{
	class Program
	{
		static void Main(string[] args)
		{
			
            RobotStrategy robot1 = new RobotStrategy(new ARobotFactory());
			robot1.DefineStrategy();

			RobotStrategy robot2 =new RobotStrategy(new BRobotFactory());
			robot2.DefineStrategy();
			Console.ReadLine();
			
		}
	}
}
