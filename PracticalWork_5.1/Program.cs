using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PracticalWork_5._1
{
    internal class Program
    {
        
        static string[] GetSeparateWord(string n)
        {
            string[] words = n.Split(' ');
            return words;
        }

        static void OutputWords(string[] words)
        {
            foreach (var word in words)
            {
                Console.WriteLine(word);
            }
        }

        static void TranspositionWords(string[] words)
        {
            string NewSentence = "";
            for (int i = 0; i < words.Length; i++)
            {
                NewSentence += words[words.Length - 1 - i] + " ";
            }
            Console.WriteLine(NewSentence);
        }
        static void Main(string[] args)
        {
            Console.WriteLine("Введите предложение:");

            #region Задание 1. Метод разделения строки на слова
            
            string n = Console.ReadLine();
            string[] words = GetSeparateWord(n);

            GetSeparateWord(n);
            OutputWords(words);
            #endregion

            #region Задание 2. Перестановка слов в предложении

            //string n = Console.ReadLine();
            //TranspositionWords(GetSeparateWord(n));

            #endregion

            Console.ReadLine();
        }
    }
}
