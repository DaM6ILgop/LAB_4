using System;
using System.Text.RegularExpressions;

namespace Lab_4
{
    class Program
    {
        static void Main(string[] args)
        {
            bool find = false; 
            byte lexaschetchik;
            string str = Console.ReadLine();
            Console.WriteLine("метод string");
            for (int i = 0; i < str.Length; i++) {           
                if (str.IndexOf(str[i]) == str.LastIndexOf(str[i])) {
                    Console.Write(str[i] + " ");
                }                             
            }
            Console.WriteLine(" ");
            Console.WriteLine("char array");
            char[] array = str.ToCharArray();
            for (int i = 0; i < array.Length; i++) {
                lexaschetchik = 0;
                for (int j = 0; j < array.Length; j++) {
                     if (array[i] == array[j]) {
                            lexaschetchik++;
                     }   
                }
                if (lexaschetchik == 1) {
                    Console.Write(array[i] + " ");
                    find = true;
                }
                if (!find) {
                    Console.WriteLine("Не найдено символов");
                }
            }
            

            
        }
         
    }
}
