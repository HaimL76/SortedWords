using System;
using System.Collections.Generic;
using System.Linq;

namespace SortedWords
{
    class Program
    {
        static void Main(string[] args)
        {
            CheckList(new[] { "bar", "banana", "apple"});
        }

        static void CheckList(string[] arr, int level = 0)
        {
            Console.WriteLine("Hello World!");

            var listChars = new LinkedList<char>();

            char? lastChar = null;

            var list = new LinkedList<string>();

            var listWords = new LinkedList<(char Letter, LinkedList<string> WordsList)>();

            for (int i = 0; i < arr.Length; i++)
            {
                string str = arr[i];

                char ch = str[0];

                if (ch == lastChar)
                {
                }
                else
                {
                    if (level > 0)
                    {

                    }
                    else
                    {
                        if (lastChar.HasValue)
                            listChars.AddLast(lastChar.Value);
                    }

                    if (list.Count > 1 && lastChar.HasValue)
                        listWords.AddLast((Letter: lastChar.Value, WordsList: list));

                    list = new LinkedList<string>();
                }

                lastChar = ch;

                if (str.Length > 1)
                    list.AddLast(str.Substring(1));
            }

            foreach (var tuple in listWords)
                CheckList(tuple.WordsList.ToArray(), level + 1);
        }
    }
}