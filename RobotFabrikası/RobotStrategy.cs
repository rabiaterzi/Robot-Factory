using System;
using System.Collections.Generic;
using System.Text;

namespace RobotFabrikası
{
	public class RobotStrategy
	{
		IRobotFactory robotStrategy;
		public RobotStrategy(IRobotFactory robotFactory)
		{
			this.robotStrategy = robotFactory;
		}
		public void DefineStrategy()
		{
			Console.WriteLine(this.robotStrategy.AddLanguage());
			Console.WriteLine(this.robotStrategy.AddDefense());
		}
	}
}
