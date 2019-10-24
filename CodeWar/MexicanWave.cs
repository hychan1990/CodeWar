using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CodeWar
{
    public class MexicanWave
    {
        public List<string> wave(string str)
        {
            List<string> l = new List<string>();
            int curr = 0;
            for (int i = 0; i < str.Length; i++)
            {
                if (str[curr]==' ')
                {
                    curr++;
                    continue;
                }
                char[] strArr = str.ToArray();
                if ((int)str[curr] >= 97 && (int)str[curr] <= 122)
                {
                    strArr[curr] = (char)(strArr[curr] - 32);
                    l.Add(string.Join("", strArr));
                }
                else
                {
                    l.Add(str);
                }
                curr++;
            }
            return l;
        }


    }
}
