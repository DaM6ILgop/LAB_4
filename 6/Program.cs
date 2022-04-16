using System;
using System.Text.RegularExpressions;

namespace Задание_6
{
    class Program
    {
        static void Main(string[] args)
        {
			Console.WriteLine("Введите строку типа 15 + 36 = 51");
			string str = Console.ReadLine();
			Regex numbers = new Regex(@"\d+");
			MatchCollection matches = numbers.Matches(str);
			foreach (Match match in matches){

				int number = int.Parse(match.Value);
				Console.Write(number + "  ");
			}
		}
    }
}
