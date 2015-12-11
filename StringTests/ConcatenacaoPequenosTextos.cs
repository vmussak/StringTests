using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StringTests
{
    public class ConcatenacaoPequenosTextos
    {
        string a, b, c, d, e;
        public ConcatenacaoPequenosTextos()
        {
            a = "A";
            b = "B";
            c = "C";
            d = "D";
            e = "E";
        }

        public void Plus()
        {
            Console.WriteLine("+");
            var time = new Stopwatch();
            time.Start();

            string x = a + b + c + d + e;

            time.Stop();
            Console.WriteLine(time.Elapsed);
            Console.WriteLine();
        }

        public void Concat()
        {
            Console.WriteLine("string.Concat");
            var time = new Stopwatch();
            time.Start();

            string x = string.Concat(a, b, c, d, e);

            time.Stop();
            Console.WriteLine(time.Elapsed);
            Console.WriteLine();
        }

        public void Join()
        {
            Console.WriteLine("string.Join");
            var time = new Stopwatch();
            time.Start();

            string x = string.Join("", a, b, c, d, e);

            time.Stop();
            Console.WriteLine(time.Elapsed);
            Console.WriteLine();
        }

        public void Interpolation()
        {
            Console.WriteLine("String Interpolation");
            var time = new Stopwatch();
            time.Start();

            string x = $"{a}{b}{c}{d}{e}";

            time.Stop();
            Console.WriteLine(time.Elapsed);
            Console.WriteLine();
        }

        public void Builder()
        {
            Console.WriteLine("String Builder");
            var time = new Stopwatch();
            time.Start();

            var sb = new StringBuilder();
            sb.Append(a)
                .Append(b)
                .Append(c)
                .Append(d)
                .Append(e);
            string x = sb.ToString();

            time.Stop();
            Console.WriteLine(time.Elapsed);
            Console.WriteLine();
        }
    }
}
