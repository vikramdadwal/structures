using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interview
{
    public static class CommonStringMethods
    {
        public static string RemoveDuplicateFromString(string input)
        {
            string output = string.Empty;
            char[] allchars = input.ToCharArray();
            Dictionary<char, string> dict = new Dictionary<char, string>();

            foreach (char character in allchars)
            {
                if (!dict.ContainsKey(character))
                {
                    dict.Add(character, "1");
                    output = output + character;
                }
            }

            return output;
        }

        public static int FindMaxInterger(int[] integerArray)
        {
            int max = integerArray[0];

            for (int i = 1; i < integerArray.Length; i++)
            {
                if (integerArray[i] > max)
                {
                    max = integerArray[i];
                }
            }

            return max;
            // Or sort the array iether last or first element would be max
            // In Binary tree the Right most node is the max value
        }

        public static string TitleCase(string input)
        {
            string result = string.Empty;
            if (string.IsNullOrWhiteSpace(input))
                return string.Empty;

            var words = input.ToLower().Split(' ');
            words[0] = CaptilizeWorld(words[0]);
            words[words.Length - 1] = CaptilizeWorld(words[words.Length - 1]);

            for (int i = 1; i < words.Length; i++)
            {
                //if (!lowerlist.Contains(words[i]))
                //{
                //    words[i] = CaptilizeWorld(words[i]);
                //}
            }

            return string.Join(" ", words);
        }

        public static string CaptilizeWorld(string word)
        {
            return char.ToUpper(word[0]) + word.Substring(1);
        }

        //given an array with strings print the unique ones 
        public static void PrintFirstNonRepeatedCharacter(string input)
        {
            Dictionary<char, int> hashmap = new Dictionary<char, int>();

            foreach (char c in input)
            {
                if (hashmap.ContainsKey(c))
                {
                    hashmap[c] = hashmap[c] + 1;
                }
                else
                {
                    hashmap.Add(c, 1);
                }
            }

            foreach (var pair in hashmap)
            {
                if (pair.Value == 1)
                {
                    Console.WriteLine(pair.Key);
                }

            }

            // Sort the array -> For loop and counter -> if countrer > 1 it is repeated else it not
        }

        public static bool AreAnagram(string first, string second)
        {
            if (first.Length != second.Length)
            {
                Console.WriteLine("Not anagram");
                return false;
            }



            foreach (char item in first)
            {
                var index = second.IndexOf(item);
                if (index > -1)
                {
                    second = second.Remove(index, 1);
                }
            }

            if (string.IsNullOrEmpty(second))
            {
                Console.WriteLine("They are anagram");
                return true;
            }

            Console.WriteLine("Not anagram");
            return false;

            // check the length -> sort both the strings -> for loop compare one by one -> if not matched they are not anagram
        }

        //Reverse the word of string = 
        // eg "Hello my name is" = "is name my hello"
        public static string ReverseWordOfString(string sentense)
        {
            Stack<string> stack = new Stack<string>();

            string[] tokens = sentense.Split(" ".ToCharArray());

            foreach (string word in tokens)
            {
                stack.Push(word);
            }

            string output = string.Empty;

            while (stack.Count > 0)
            {
                output = output + stack.Pop() + " ";
            }

            return output;
        }


        //Reverse the word of string = 
        // eg "Hello my name is" = "is name my hello"
        public static string ReverseWordOfStringWithoutStack(string sentense)
        {
            int start = 0;
            int end = 0;
            var reverse = sentense.ToCharArray();
            ReverseString(reverse, 0, sentense.Length - 1);

            while (end < reverse.Length)
            {
                if (reverse[end].Equals(' '))
                {
                    ReverseString(reverse, start, end - 1);
                    start = end + 1;
                }

                end++;

            }

            ReverseString(reverse, start, end - 1);

            return string.Join("" , reverse);
        }

        public static void ReverseString(char[] characters, int start, int end)
        {
            while (start < end)
            {
                var temp = characters[end];
                characters[end] = characters[start];
                characters[start] = temp;

                start++; end--;
            }

            
        }


    }
}
