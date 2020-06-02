using System;
using System.Collections.Generic;
using System.Text;

namespace LV7
{
    class Pali
    {
        public static string word = string.Empty;

        public Pali(string TheWord)
        {
            word = TheWord;
        }
        public static void Unos()
        {
            Console.WriteLine("Unesi:");
            word = Console.ReadLine();
            if (GetIsWordPali(word))
                Console.WriteLine("Je");
            else
                Console.WriteLine("Nije");
        }
        public static bool GetIsWordPali(string testWord)
        {
            testWord = testWord.Replace(" ", "");
            testWord = testWord.ToLower();
            string first = testWord.Substring(0, testWord.Length / 2);
            char[] arr = testWord.ToCharArray();

            Array.Reverse(arr);

            string temp = new string(arr);
            string second = temp.Substring(0, temp.Length / 2);

            return first.Equals(second);
        }
    }
}
