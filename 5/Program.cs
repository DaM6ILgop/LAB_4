using System;
using System.Text.RegularExpressions;

namespace Задние_5
{
    class Program
    {
        static void Main(string[] args)
        {          
            string str = Console.ReadLine();
            //string variant = Console.ReadLine();
            //switch (variant) {           
            //}
            Regex regex = new Regex(@"\b[A-Z](\w*)+\d{2}\b");
            MatchCollection matchers = regex.Matches(str);           
                if (matchers.Count > 0) {                
                    foreach (Match match in matchers){
                        Console.WriteLine("Через Regex:" + match.Value);
                    }
                }
                else{              
                    Console.WriteLine("Ошибка. В строке нет подходящего элемента");
                }
            Console.WriteLine("");
            Console.WriteLine("Через массив символов");

            string[] array = str.Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
            for (int i = 0; i < array.Length; i++) {

                string elementArray = array[i];
                if (Char.IsUpper(elementArray[0]) && Char.IsNumber(elementArray[elementArray.Length - 1]) && Char.IsNumber(elementArray[elementArray.Length - 2]))                   
                {
                    Console.WriteLine(array[i]);
                }
                else if ((!Char.IsUpper(elementArray[0]) && Char.IsNumber(elementArray[elementArray.Length - 1]) && Char.IsNumber(elementArray[elementArray.Length - 2]))) {
                    Console.WriteLine("Ошибка");
                }
            } 
        }
            
    }
}
