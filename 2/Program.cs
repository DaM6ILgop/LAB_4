using System;

namespace Задание_2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите строку");
            string str = Console.ReadLine();
            Console.WriteLine("Выберите способ: \n 1)array-1 \n 2)string-2\n entered the number");
            string sposob = Console.ReadLine();
            switch (sposob) {
                case "1":
                    array(str);
                    break;
                case "2":
                    Char(str);
                    break;
            }    
        }
        static void array(string str) {
            string[] st = str.Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
           
            int x = 0;
            foreach (var sub in st)
            {
                x++;
                Console.Write($"{sub} ({x})");
            }
        }
        static void Char(string str)
        {
            string[] split = str.Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
            char[] CharArray = str.ToCharArray();
            int x = 0;
            foreach (var sub in CharArray)
            {
                x++;
                Console.WriteLine($"{sub} ({x})");
            }
        }
    }
}
 