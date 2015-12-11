using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StringTests
{
    public class Formatacao
    {
        private readonly int[] _lista;
        public Formatacao()
        {
            _lista = new int[10000];
            for (int i = 0; i < 10000; i++)
                _lista[i] = i;
        }

        public void Format()
        {
            Console.WriteLine("string.Format");
            var time = new Stopwatch();
            time.Start();

            string x;
            foreach (var item in _lista)
                x = string.Format("{0:00000-000}", item);

            time.Stop();
            Console.WriteLine(time.Elapsed);
            Console.WriteLine();
        }

        public void FormatToString()
        {
            Console.WriteLine("ToString");
            var time = new Stopwatch();
            time.Start();

            string x;
            foreach (var item in _lista)
                x = item.ToString("00000-000");

            time.Stop();
            Console.WriteLine(time.Elapsed);
            Console.WriteLine();
        }

        public void StringInterpolation()
        {
            Console.WriteLine("String Interpolation");
            var time = new Stopwatch();
            time.Start();

            string x;
            foreach (var item in _lista)
                x = $"{item:00000-000}";

            time.Stop();
            Console.WriteLine(time.Elapsed);
            Console.WriteLine();
        }
    }
}
