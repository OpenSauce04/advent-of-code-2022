using System;
using System.Reflection;
using System.Linq;

namespace Day3Part1
{
	internal class Program
	{
		static int GetLetterValue(char letter)
		{
			int value = (int)Char.ToUpper(letter) - 64;
			if (Char.ToLower(letter) != letter)
			{
				value += 26;
			}

			return value;
		}
		static void Main(string[] args)
		{
			int totalPriority = 0;
			foreach (string x in File.ReadAllLines(Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location) + "/input.txt"))
			{
				char[] chars = x.ToCharArray();
				char[] firstCompartment = chars.Take(chars.Length / 2).ToArray();
				char[] secondCompartment = chars.Skip(chars.Length / 2).ToArray();

				foreach (char y in firstCompartment)
				{
					if (secondCompartment.Contains(y)) {
						totalPriority += GetLetterValue(y);
						break;
					}
				}

			}
			Console.WriteLine(totalPriority);

		}
	}
}