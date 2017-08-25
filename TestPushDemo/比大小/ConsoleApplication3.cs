using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApplication3  
{
	class Program
	{
		static void Main(string[] args)
		{
			int a = 10;
			int b = 2;
			int c = 10;
			int d = 1123;

            //大于 返回1
			Console.WriteLine(a.CompareTo(b)); 
			//等于 返回0
			Console.WriteLine(a.CompareTo(c));
			//小于 返回-1
			Console.WriteLine(a.CompareTo(d));
			Console.ReadLine();
		}
	}

}