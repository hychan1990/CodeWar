using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CodeWar
{
    class ValidParentheses20
    {
        public bool IsValid(string s)
        {
            //when recorded a open, next one must be [other open] or [same close]
            //if recorded a close before opened, false
            while (s.Contains("()") || s.Contains("{}") || s.Contains("[]"))
            {
                s = s.Replace("()", "");
                s = s.Replace("{}", "");
                s = s.Replace("[]", "");
            }
            return s.Length == 0;
            ////()
            //List<char> open = new List<char>(new char[]{ '(', '{', '[' });
            //List<char> close = new List<char>(new char[] { ')', '}', ']' });
            //bool opened = false;
            //bool closed = false;
            //for (int i = 0; i < s.Length; i++)
            //{
            //    if (close.Contains(s[i]) && !open.Contains(s[i - 1])) //close without open
            //    {
            //        return false;
            //    }

            //    if (open.Contains(s[i]))
            //    {
            //        opened = true;
            //    }

            //}

        }
    }
}
