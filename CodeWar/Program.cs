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
            MexicanWave mw = new MexicanWave();
            var l = mw.wave("here come");
            foreach (string item in l)
            {
                Console.WriteLine(item);
            }
            Console.Read();
        }
    }
}
