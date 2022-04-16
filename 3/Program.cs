using System;
using System.Text;

namespace Задание_3
{
    class Program
    {
        
        static void Main(string[] args)
        {
            string str;
            while (true)
            {
                try {                
                    Console.WriteLine("Введите строку, закончив точкой");
                    str = Console.ReadLine();
                    bool check = str.Contains(".");
                    if (!check) {
                        throw new Exception("Ввод необходимо завершить точкой");
                    }                   
                }
                catch (Exception) {
                    Console.WriteLine("что-то не так");
                    continue;
                }
                break;
            }     

            Console.WriteLine("Выберите способ.\n 1 - charArray\n 2 - StringBuilder\n 3 - String");
            string cace = Console.ReadLine();
            switch(cace){
                case "1":
                    charArray(str);
                    break;
                case "2":
                    ReverseString(str);
                    break;
                case "3":
                    stroka(str);
                    break;
            }         
        }
        static void charArray(string str)
        {
            string[] array = str.Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
            char[] Char = str.ToCharArray();
            string output = string.Empty;

            for (int i = Char.Length - 1; i >= 0; i--){
                output += Char[i];   
            }
            Console.Write(output);
        }
        static void ReverseString(string str) {
            StringBuilder sb = new StringBuilder();
            for (int i = str.Length - 1; i >= 0; i--) {
                sb.Append(str[i] + " ");
            }
            string strokaPosleBildera = sb.ToString();
            Console.WriteLine(strokaPosleBildera);
        }
        static void stroka(string str) {
            string[] strochka = str.Split(new char[] { ' ', '.' }, StringSplitOptions.RemoveEmptyEntries);
            Array.Reverse(strochka);
            for (int i = 0; i < strochka.Length; i++) {
                if (i == strochka.Length - 1)
                {
                    Console.Write(strochka[i] + ".");
                }
                else {
                    Console.Write(strochka[i] + " ");
                }
            }
        }
    }   
}
