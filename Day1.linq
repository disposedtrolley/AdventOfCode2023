<Query Kind="Statements" />

#load "Utils.linq"

using System;

List<string> input = ReadInput("Day1.txt");

void PartOne()
{
	int sum = 0;
	foreach (string line in input)
	{
		List<int> digits = new List<int>();
		foreach (char ch in line)
		{
			int digit;
			if (int.TryParse(ch.ToString(), out digit))
			{
				digits.Add(digit);
			}
		}
		sum += int.Parse(digits.First().ToString() + digits.Last().ToString());
	}

	Console.WriteLine($"Part 1: {sum}");
}

void PartTwo()
{
	List<string> validDigitWords = new List<string> { "one", "two", "three", "four", "five", "six", "seven", "eight", "nine" };
	
	int sum = 0;
	foreach (string line in input)
	{
		List<int> digits = new List<int>();
		string buf = "";
		foreach (char ch in line)
		{
			int digit;
			if (int.TryParse(ch.ToString(), out digit))
			{
				digits.Add(digit);
			}
			
			buf += ch;
			for (int i = 0; i < validDigitWords.Count; i++)
			{
				if (buf.Contains(validDigitWords[i]))
				{
					digits.Add(i+1);
					// Handle shit like 'oneight'
					buf = buf.Substring(buf.Length-1);
				}
			}
		}
		sum += int.Parse(digits.First().ToString() + digits.Last().ToString());
	}

	Console.WriteLine($"Part 2: {sum}");
}


PartOne();
PartTwo();