using System;
using System.Text;

namespace _02112021
{
    class Program
    {
        static void Main(string[] args)
        {
            string sentence = "  Hello     World       Dunya";
            Console.WriteLine(sentence);

            RemoveExtraSpaces(ref sentence);
            Console.WriteLine(sentence);

            string[] wordsArr = MakeWordsArr(sentence);
            Console.WriteLine($"words count: {wordsArr.Length}");
            foreach (var item in wordsArr)
            {
                Console.WriteLine(item);
            }

            string[] sentenceArr =
            {
                "  Hello     World       Dunya",
                "  Salam       Dunya",
                null,
                "P201 programming    group   "
            };

            string[] lastWords = MakeLastWordsArr(sentenceArr);

            Console.WriteLine(lastWords.Length);
            foreach (var item in lastWords)
            {
                Console.WriteLine(item);
            }
        }

        static void RemoveExtraSpaces(ref string str)
        {
            StringBuilder stringBuilder = new StringBuilder();

            str = str.Trim();
            int spaceCount = 0;
            foreach (var item in str)
            {
                if (item == ' ')
                {
                    if (spaceCount == 0) stringBuilder.Append(item);
                    spaceCount++;
                }
                else if (item != ' ')
                {
                    //str += item;
                    stringBuilder.Append(item);
                    spaceCount = 0;
                }
            }
            str = stringBuilder.ToString();
        }
        static string[] MakeWordsArr(string str)
        {
            RemoveExtraSpaces(ref str);
            var arr = str.Split(' ');

            return arr;
        }

        static bool CheckStr(string str)
        {
            bool hasDigit = false;
            bool hasLower = false;
            bool hasUpper = false;

            for (int i = 0; i < str.Length; i++)
            {
                if (!hasDigit && char.IsDigit(str[i])) hasDigit = true;
                if (!hasUpper && char.IsUpper(str[i])) hasUpper = true;
                if (!hasLower && char.IsLower(str[i])) hasLower = true;

                if (hasDigit && hasLower && hasUpper) return true;
            }

            return false;
        }

        static string[] MakeLastWordsArr(string[] arr)
        {
            string[] words = new string[0];

            foreach (var item in arr)
            {
                if (!string.IsNullOrWhiteSpace(item))
                {
                    string lastWord = item.Trim().Substring(item.Trim().LastIndexOf(' ')+1);
                    Array.Resize(ref words, words.Length+1);
                    words[words.Length - 1] = lastWord;
                }
            }

            return words;
        }
    }
}
