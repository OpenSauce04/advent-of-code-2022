using System;
using System.Reflection;
using System.Linq;
using System.IO;
using System.Collections;

namespace Day3Part2
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
			ArrayList groups = new ArrayList();
			int line = 0;

			{
				string[] group = new string[3];
				foreach (string x in File.ReadAllLines(Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location) + "/input.txt"))
				{
					group[line % 3] = x.Trim();
					if (line % 3 == 2)
					{
						groups.Add(group);
						group = new string[3];
					}
					line++;
				}
			}
			
			foreach (string[] group in groups)
			{
				foreach (char letter in group[0].ToCharArray())
				{
					if (group[1].Contains(letter) && group[2].Contains(letter))
					{
						totalPriority += GetLetterValue(letter);
						break;
					}
				}
			}

			Console.WriteLine(totalPriority);
		}
	}
}