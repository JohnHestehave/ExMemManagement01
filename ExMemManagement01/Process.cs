using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExMemManagement01
{
	public class Process
	{
		public char ProcessID;
		public Page[] PageTable;
		public Process(char c, Page[] pages)
		{
			ProcessID = c;
			PageTable = pages;
		}
	}
}
