using System;
using System.IO;
using System.Reflection;
namespace Day1
{
	internal class Program
	{
		static void Main(string[] args)
		{
			int highCalories = 0;
			int runningCalories = 0;
			foreach (string x in File.ReadAllLines(Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location) + "/input.txt")) {
				if (x == "")
				{
					runningCalories = 0;
				} else
				{
					runningCalories += Int32.Parse(x.Trim());
					highCalories = Math.Max(runningCalories, highCalories);
				}
			}
			Console.WriteLine(highCalories);
		}
	}
}