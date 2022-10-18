using System;
using System.Collections.Generic;

namespace Hashshet
{
	class Program
	{
		public static void Main(string[] args)
		{
			HashSet<int> set1 = new HashSet<int>();
            HashSet<int> set2 = new HashSet<int>();
            HashSet<int> type1 = new HashSet<int>();
            HashSet<int> type2 = new HashSet<int>();
            HashSet<int> test1 = new HashSet<int>();
            HashSet<int> test2 = new HashSet<int>();

            int input;

			Console.WriteLine("====HashSet1====");
			for (int i = 0; i < 5; i++)
			{
				Console.Write($"Element {i}: ");
				input = int.Parse(Console.ReadLine());
				set1.Add(input);
				type1.Add(input);
				test1.Add(input);
			}

			Console.WriteLine("====HashSet2====");
			for (int i = 0; i < 5; i++)
			{
				Console.Write($"Element {i}: ");
				input = int.Parse(Console.ReadLine());
				set2.Add(input);
				type2.Add(input);
				test2.Add(input);
			}

			Console.Write("UNION: ");
			set1.UnionWith(set2);
			foreach (int item in set1)
			{
				Console.Write(" ");
				Console.Write(item);
            }

            Console.Write("\nINTERSECTION: ");
			type1.IntersectWith(type2);
			foreach (int item in type1)
			{
				Console.Write(" ");
				Console.Write(item);
			}

            Console.Write("\nSET DIFFERENCE:");
			test1.ExceptWith(test2);
			foreach (int item in test1)
			{
				Console.Write(" ");
				Console.Write(item);
			}
    }
	}
}

