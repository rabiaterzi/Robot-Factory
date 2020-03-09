using System;
using System.Collections.Generic;
using System.Text;

namespace RobotFabrikası
{
	public class ARobotFactory : IRobotFactory
	{
		public string AddDefense()
		{
			return "a savunması eklendi";
		}

		public string AddLanguage()
		{
			return "a dili eklendi";
		}
	}
}
