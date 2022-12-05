using System.Collections;
using System.IO;
using System.Reflection;
using System;

namespace Day2Part1
{
	internal class Program
	{
		static void Main(string[] args)
		{
			ArrayList moveList = new ArrayList();
			int score = 0;

			foreach (string x in File.ReadAllLines(Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location) + "/input.txt"))
			{
				moveList.Add(x.Split(' '));
			}

			foreach (string[] x in moveList)
			{
				switch (x[1])
				{
					case "X":
						score += 1;
						if (x[0] == "A") score += 3;
						if (x[0] == "C") score += 6;
						break;
					case "Y":
						score += 2;
						if (x[0] == "B") score += 3;
						if (x[0] == "A") score += 6;
						break;
					case "Z":
						score += 3;
						if (x[0] == "C") score += 3;
						if (x[0] == "B") score += 6;
						break;
				}
			}

			Console.WriteLine(score);
		}
	}
}