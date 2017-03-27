using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExMemManagement01
{
	class Program
	{
		static void Main(string[] args)
		{
			MemoryManagement mm = new MemoryManagement();
			bool running = true;
			while (running)
			{
				Console.WriteLine("1: Create new Process");
				Console.WriteLine("2: Delete Process");
				Console.WriteLine("3: Show Process");
				Console.WriteLine("0: Exit");
				string input = Console.ReadLine();
				switch (input)
				{
					case "1":
						mm.CreateProcess('A');
						mm.CreateProcess('B');
						mm.CreateProcess('C');

						Console.WriteLine(mm.ShowProcess('B'));

						break;
					case "2":
						break;
					case "3":
						break;
					case "0":
						running = false;
						break;
					default:
						running = false;
						break;
				}
			}
			Console.WriteLine("Goodbye!");
			Console.ReadKey();
		}
	}
}
