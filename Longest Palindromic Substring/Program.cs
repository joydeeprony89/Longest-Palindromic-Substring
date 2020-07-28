using System;

namespace Longest_Palindromic_Substring
{
    class Program
    {
        static void Main(string[] args)
        {
            Program program = new Program();
            Console.WriteLine(program.LongestPalindrome("forgeeksskeegfor"));
            Console.WriteLine("Hello World!");
        }

        public string LongestPalindrome(string s)
        {
            if (string.IsNullOrEmpty(s)) return "";
            var arr = s.ToCharArray(); 
            string result = arr[0].ToString();

            int length = s.Length;
            for (int i = 0; i < length; i++)
            {
                for (int j = i + 1; j < length; j++)
                {
                    if (PalindromeExist(s, i, j, arr))
                    {
                        string newPalindrome = s.Substring(i, j - i + 1);
                        result = newPalindrome.Length > result.Length ? newPalindrome : result;
                    }
                }
            }
            return result;
        }

        private bool PalindromeExist(string s, int start, int end, char[] arr)
        {
            for (int i = start, j = end; i < end; i++)
            {
                if (arr[i] == arr[j--]) continue;
                else return false;
            }

            return true;
        }
    }
}
