using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApplication2  
{
	class Rrogram
	{
		public static void Main(){
			Convert(" 179  ");
			Convert(" -204  ");
			Convert(" +809  ");
			Convert("  178.3  ");
			Console.ReadLine();
		}

		private static void Convert(string value)
		{
			try
			{
				//将数字的字符串表示形式转换为它的等效 32 位有效符号整数。
				int number = int.Parse(value);
				Console.WriteLine("Converted '{0}' to {1}.",value,number);
			}
			catch(FormatException)
			{
				Console.WriteLine("Unable to convert '{0}'.",value);
			}
		}
	}
}