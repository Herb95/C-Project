using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApplication4
{
	class Program
	{
		static void Main(string[] args)
		{
			List<int> list = new List<int>();
			list.Add(-2);
			list.Add(10);
			list.Add(8);
			list.Add(6);
			list.Add(4);
			list.Add(11);

			//1
			list.Sort();
			//输出 -2 4 6 8 10 11 从小到大的排序
			Print(list);

			//2
			list.Sort(
				delegate(int a,int b)
				{
					return a.CompareTo(b);
				}
			);
			//输出 -2 4 6 8 10 11 从小到大的排序
			Print(list);

			//3
			list.Sort((a, b) => b.CompareTo(a));
			//输出 -2 4 6 8 10 11 从大到小的排序
			 Print(list);

			Console.ReadLine();
		}

		static void Print(List<int> list)
		{
			for(int i = 0; i < list.Count; i++)
			{
				Console.WriteLine("{0}",list[i]);
			}
			Console.WriteLine();
		}

	}
}
