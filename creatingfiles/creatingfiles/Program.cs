using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace creatingfiles
{
    class Program
    {
        static void Main(string[] args)
        {
            Stopwatch timer = new Stopwatch();


            string[] data = new string[10000];
            for (int i = 0; i < 10000; i++)
            {
                if (i % 1000 == 0) { Console.WriteLine(i); }

                data[i] = Guid.NewGuid().ToString();
            }

            timer.Start();
            File.AppendAllLines(@"c:\temp\mydatawrittenonce.txt", data);
            timer.Stop();
            Console.WriteLine(timer.ElapsedMilliseconds);

        }
    }
}
