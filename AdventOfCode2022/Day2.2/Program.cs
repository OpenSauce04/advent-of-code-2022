using System.Collections;
using System.IO;
using System.Reflection;
using System;

namespace Day2Part2
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
						//score += 0;
						if (x[0] == "A") score += 3; //Z
						if (x[0] == "B") score += 1; //X
						if (x[0] == "C") score += 2; //Y
						break;

					case "Y":
						score += 3;
						if (x[0] == "A") score += 1; //X
						if (x[0] == "B") score += 2; //Y
						if (x[0] == "C") score += 3; //X
						break;

					case "Z":
						score += 6;
						if (x[0] == "A") score += 2; //Y
						if (x[0] == "B") score += 3; //Z
						if (x[0] == "C") score += 1; //X
						break;
				}
			}

			Console.WriteLine(score);
		}
	}
}