namespace Dr.LeeFinalQ5
{
    using System;
    using System.Collections.Generic;

    public class Program
    {
        public static void Main()
        {
            // Test cases
            Console.WriteLine(IsDoubloon("Abba"));    // True
            Console.WriteLine(IsDoubloon("Civic"));   // False
            Console.WriteLine(IsDoubloon("noon"));    // True
            Console.WriteLine(IsDoubloon("Deed"));    // True
            Console.WriteLine(IsDoubloon("hello"));   // False
        }

        public static bool IsDoubloon(string word)
        {
            // Convert the word to lowercase to ignore case sensitivity
            word = word.ToLower();

            // Dictionary to count occurrences of each character
            Dictionary<char, int> charCount = new Dictionary<char, int>();

            // Count the occurrences of each character in the word
            foreach (char c in word)
            {
                if (charCount.ContainsKey(c))
                {
                    charCount[c]++;
                }
                else
                {
                    charCount[c] = 1;
                }
            }

            // Check if every character appears exactly twice
            foreach (var count in charCount.Values)
            {
                if (count != 2)
                {
                    return false;
                }
            }

            return true;
        }
    }

}
