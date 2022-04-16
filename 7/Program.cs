using System;
using System.Collections.Generic;
using System.Text.RegularExpressions;

namespace Задание_7
{
    class Program
    {
		static void Main(string[] args)
		{
			string[] list = new string[10];
			list[0] = "Gentle Giant – Free Hand [06:15]";
			list[1] = "Supertramp – Child Of Vision [07:27]";
			list[2] = "Camel – Lawrence [10:46]";
			list[3] = "Yes – Don’t Kill The Whale [03:55]";
			list[4] = "10CC – Notell Hotel [04:58]";
			list[5] = "Nektar – King Of Twilight [04:16]";
			list[6] = "The Flower Kings – Monsters & Men [21:19]";
			list[7] = "Focus – Le Clochard [01:59]";
			list[8] = "Pendragon – Fallen Dream And Angel [05:23]";
			list[9] = "Kaipa – Remains Of The Day [08:02]";
				
			int sum = 0;
			
			int maxValue = 0;

			for (int i = 0; i < list.Length; i++) {
                Console.WriteLine(list[i]);

				Regex minuta = new Regex(@"(\d{2})(?=:)");
				MatchCollection min = minuta.Matches(list[i]);
				foreach (Match m in min) {
					int g = int.Parse(m.Value); //Парсим строковое значение в число                   
                    Console.WriteLine("Минуты :" + g);
                    Console.WriteLine(" ");
					sum += g;
                    
                    
				}		
			}
			Console.WriteLine($"Сумма минут песен равна  {sum}-минутам");
            Console.WriteLine("");
			string longest = string.Empty;
			string Short = string.Empty;
			int minValue = int.MaxValue;//Не знаю для чего MAX, но без этого не работает 
			int valueCollection = 0;
			for (int j = 0; j < list.Length; j++) {
				Regex length = new Regex(@"(\d{2})(?=:)");
				MatchCollection len = length.Matches(list[j]);
				foreach (Match le in len)
				{
					valueCollection = int.Parse(le.Value);
					if (maxValue < valueCollection)
					{
						maxValue = valueCollection;
						longest = list[j];
					}
					if (minValue > valueCollection) {
						minValue = valueCollection;
						Short = list[j];

					}
					
				}
			}
            Console.WriteLine("Самаяя длинная:" + longest);
            Console.WriteLine("Самая короткая:" + Short);
			
		}	
			 
			
		
            

		
    }
}
