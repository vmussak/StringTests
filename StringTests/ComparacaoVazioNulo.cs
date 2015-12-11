using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StringTests
{
    public class ComparacaoVazioNulo
    {
        private readonly string[] _lista;

        public ComparacaoVazioNulo()
        {
            _lista = new string[5000];
            for (int i = 0; i < 5000; i++)
                _lista[i] = Guid.NewGuid().ToString();
        }

        public void IsNullOrEmpty()
        {
            Console.WriteLine("string.IsNullOrEmpty");
            var time = new Stopwatch();
            time.Start();

            bool x;
            for (int i = 0; i < _lista.Length; i++)
                x = string.IsNullOrEmpty(_lista[i]);

            time.Stop();
            Console.WriteLine(time.Elapsed);
            Console.WriteLine();
        }

        public void IsNullOrWhiteSpace()
        {
            Console.WriteLine("string.IsNullOrWhiteSpace");
            var time = new Stopwatch();
            time.Start();

            bool x;
            for (int i = 0; i < _lista.Length; i++)
                x = string.IsNullOrWhiteSpace(_lista[i]);

            time.Stop();
            Console.WriteLine(time.Elapsed);
            Console.WriteLine();
        }

        public void Common()
        {
            Console.WriteLine(@"== null || == """"");
            var time = new Stopwatch();
            time.Start();

            bool x;
            foreach (var item in _lista)
                x = item == null || item == "";

            time.Stop();
            Console.WriteLine(time.Elapsed);
            Console.WriteLine();
        }
    }
}
