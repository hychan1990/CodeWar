using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CodeWar
{
    class Program
    {
        static void Main(string[] args)
        {
            ValidParentheses20 validParentheses20 = new ValidParentheses20();
            Console.WriteLine(validParentheses20.IsValid("{}"));
            Console.WriteLine(validParentheses20.IsValid("()[]{}"));
            Console.WriteLine(validParentheses20.IsValid("(]"));
            Console.WriteLine(validParentheses20.IsValid("([)]"));
            Console.WriteLine(validParentheses20.IsValid("{[]}"));
            Console.WriteLine(validParentheses20.IsValid(""));
            Console.Read();
        }
    }
}
