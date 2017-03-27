using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExMemManagement01
{
	public class MemoryManagement
	{
		static List<Process> ProcessTable = new List<Process>();
		static Frame[] Frames = new Frame[20];
		Random rand = new Random();
		public void CreateProcess(char c)
		{
			int size = rand.Next(1, 7);
			int count = 0;
			Console.WriteLine(c+" of size: "+size);
			for (int i = 0; i < Frames.Length; i++)
			{
				if(Frames[i] == null)
				{
					count++;
					if (count >= size) break;
				}
			}
			if (count < size)
			{
				throw new Exception("Error: Cannot create process.");
			}else
			{
				Page[] pages = new Page[size];
				for (int i = 0; i < Frames.Length; i++)
				{
					if (Frames[i] == null)
					{
						Page page = new Page(i);
						for (int u = 0; u < pages.Length; u++)
						{
							if(pages[u] == null)
							{
								pages[u] = page;
							}
						}
						Frames[i] = new Frame();
						size--;
						if (size == 0) break;
					}
				}
				Process process = new Process(c, pages);
				ProcessTable.Add(process);
			}
		}
		public string ShowProcess(char c)
		{
			string s = "Frames("+c+"): ";
			foreach (Process p in ProcessTable)
			{
				if(p.ProcessID == c)
				{
					for (int i = 0; i < p.PageTable.Length; i++)
					{
						s += "[]";
					}
				}
			}
			return s;
		}
	}
}
