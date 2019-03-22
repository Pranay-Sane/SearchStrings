using System;
using System.Linq;

namespace Solution2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(SerachStrings("hello", "Hello"));
            Console.WriteLine(SerachStrings("hello", "hi"));
            Console.WriteLine(SerachStrings("Alien", "line"));
        }

        static bool SerachStrings(string target, string match)
        {
            return match.ToLower().All(l => target.ToLower().IndexOf(l) != -1);
        }
    }
}
