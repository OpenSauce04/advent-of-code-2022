using System;
using System.IO;
using System.Reflection;
using System.Collections;

namespace Day1Part2
{
	internal class Program
	{
		static void Main(string[] args)
		{
			ArrayList caloriesList = new ArrayList();
			int runningCalories = 0;
			foreach (string x in File.ReadAllLines(Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location) + "/input.txt")) {
				if (x == "")
				{
					caloriesList.Add(runningCalories);
					runningCalories = 0;
				} else
				{
					runningCalories += Int32.Parse(x.Trim());
				}
			}
			caloriesList.Sort();
			caloriesList.Reverse();
			Console.WriteLine((int)caloriesList[0] + (int)caloriesList[1] + (int)caloriesList[2]);
		}
	}
}