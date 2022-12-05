using System;
using System.Collections.Generic;
using System.IO;
using System.Reflection;

namespace Day4Part1
{
	internal class Program
	{
		static List<string[][]> splitPairs = new List<string[][]>();
		static void Main(string[] args)
		{
			
			int index = 0;
			int overlaps = 0;

			foreach (string x in File.ReadAllLines(Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location) + "/input.txt"))
			{
				string[] tempArrayA = x.Split(',');
				string[][] tempArrayB = new string[2][];
				tempArrayB[0] = tempArrayA[0].Split('-');
				tempArrayB[1] = tempArrayA[1].Split('-');
				splitPairs.Add(tempArrayB);
				index++;
			}
			foreach (string[][] x in splitPairs)
			{
				if (Int32.Parse(x[0][0]) <= Int32.Parse(x[1][0])
				&&  Int32.Parse(x[0][1]) >= Int32.Parse(x[1][1])
				|| (Int32.Parse(x[1][0]) <= Int32.Parse(x[0][0])
				&&  Int32.Parse(x[1][1]) >= Int32.Parse(x[0][1]))) {
					overlaps++;
				}
			}

			Console.WriteLine(overlaps);
		}
	}
}