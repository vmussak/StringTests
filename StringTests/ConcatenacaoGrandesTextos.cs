using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StringTests
{
    public class ConcatenacaoGrandesTextos
    {
        private readonly string[] _lista;

        public ConcatenacaoGrandesTextos()
        {
            _lista = new string[5000];
            for (int i = 0; i < 5000; i++)
                _lista[i] = Guid.NewGuid().ToString();
        }

        public void Plus()
        {
            Console.WriteLine("+");
            var time = new Stopwatch();
            time.Start();

            string x = "";
            for (int i = 0; i < _lista.Length; i++)
                x = x + _lista[i];

            time.Stop();
            Console.WriteLine(time.Elapsed);
            Console.WriteLine();
        }

        public void Plus2()
        {
            Console.WriteLine("+=");
            var time = new Stopwatch();
            time.Start();

            string x = "";
            for (int i = 0; i < _lista.Length; i++)
                x += _lista[i];

            time.Stop();
            Console.WriteLine(time.Elapsed);
            Console.WriteLine();
        }

        public void Concat()
        {
            Console.WriteLine("string.Concat");
            var time = new Stopwatch();
            time.Start();

            string x = string.Concat(_lista);

            time.Stop();
            Console.WriteLine(time.Elapsed);
            Console.WriteLine();
        }

        public void Join()
        {
            Console.WriteLine("string.Join");
            var time = new Stopwatch();
            time.Start();

            string x = string.Join("", _lista);

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
            for (int i = 0; i < _lista.Length; i++)
                sb.Append(_lista[i]);

            string x = sb.ToString();

            time.Stop();
            Console.WriteLine(time.Elapsed);
            Console.WriteLine();
        }

    }
}
