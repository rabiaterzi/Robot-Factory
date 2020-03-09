using System;
using System.Collections.Generic;
using System.Text;

namespace RobotFabrikası
{
	public class BRobotFactory : IRobotFactory
	{
		public string AddDefense()
		{
			return "b savunması eklendi";
		}

		public string AddLanguage()
		{
			return "b dili eklendi";
		}
	}
}
