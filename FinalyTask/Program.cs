using System;

namespace FinalyTask
{
    class Program
    {

        static void PrintResult(string[] result, int expected_length) 
        {
            Console.WriteLine($"Слова с длиной <= {expected_length}");
            for (var i = 0; i < result.Length; i++)
                Console.Write($"{result[i]} ");
        }

        static void SetResult(string[] words, int expected_length, string[] result) 
        {
            var count = 0;
            for (var i = 0; i < words.Length; i++)
                if (words[i].Length <= expected_length) 
                {
                    result[count] = words[i];
                    count++;
                }
        }

        static int GetCountWordsWithExpectedLength(string[] words, int expected_length) 
        {
            var count = 0;
            for (var i = 0; i < words.Length; i++)
                if (words[i].Length <= expected_length)
                    count++;
            return count;
        }

        static string[] ParseInputLine(string input_line) 
        {
            var separators = new char[] { '.', ',', ' ', ':', ';', '"', '\'', '?', '!'};
            return input_line.Split(separators, StringSplitOptions.RemoveEmptyEntries);
        }

        static void Main(string[] args)
        {
            Console.WriteLine("Введите предложение:");
            var input_line = Console.ReadLine();
            var parsed_lines = ParseInputLine(input_line);
            var expected_length = 3;
            var expected_count = GetCountWordsWithExpectedLength(parsed_lines, expected_length);
            var result = new string[expected_count];
            SetResult(parsed_lines, expected_length, result);
            PrintResult(result, expected_length);
        }
    }
}
