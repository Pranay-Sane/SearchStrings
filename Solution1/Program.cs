using System;

namespace Solution1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(SerachStrings("hello","Hello"));
            Console.WriteLine(SerachStrings("hello","hi"));
            Console.WriteLine(SerachStrings("Alien","line"));
        }

        static bool SerachStrings(string target, string match)
        {
            foreach (char item in match.ToLower())
            {
                if (target.ToLower().IndexOf(item) == -1) return false;
            }
            return true;
        }
    }
}
