using System;

namespace Задание_4
{
    class Program
    {
        static void Main(string[] args)
        {
            int lenght = 7;
            string[] str = new string[lenght];
            for (int i = 0; i < str.Length; i++) {
                str[i] = Console.ReadLine();
            }
            Console.WriteLine(" ");
            int a = 1;
            for (int i = 0; i < lenght; i++) {
                Console.WriteLine($"{a}: {str[i]}");
                a++;
            }
            a = 1;
            foreach (string stroka in str) {
                string lower = stroka.ToLower();
                char[] chars = lower.ToCharArray();
                Console.WriteLine();
                if (chars.Length > 3 &&
                    chars[chars.Length - 1] == 'm' &&
                    chars[chars.Length - 2] == 'o' &&
                    chars[chars.Length - 3] == 'c' &&
                    chars[chars.Length - 4] == '.') {
                    Console.WriteLine($"{a}: {stroka}");
                }
            }           
            Console.WriteLine("Через обычный массв строк");
            foreach (string stroka2 in str) {
                if (stroka2.Length > 3 &&
                   stroka2[stroka2.Length - 1] == 'm' &&
                   stroka2[stroka2.Length - 2] == 'o' &&
                   stroka2[stroka2.Length - 3] == 'c' &&
                   stroka2[stroka2.Length - 4] == '.'){      
                    Console.WriteLine($"{a}: {stroka2}");
                }
            }


        }
        
    }
}
