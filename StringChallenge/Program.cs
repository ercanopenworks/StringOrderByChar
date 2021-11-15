using System;
using System.Collections.Generic;

namespace StringChallenge
{
    class Program
    {
        public static string StringChallenge(string str)
        {

            // code goes here  
            List<char> temp = new List<char>();
            
            for (int i = 0; i < str.Length; i++)
            {
                if (Char.IsLetter(str[i]))
                {
                    temp.Add(str[i]);
                    
                }

            }
            temp.Sort();

            return string.Join("", temp);

        }

        static void Main()
        {
            // keep this function call here
            Console.WriteLine(StringChallenge(Console.ReadLine()));
        }
    }
}
