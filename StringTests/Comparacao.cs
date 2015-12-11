using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StringTests
{
    public class Comparacao
    {
        private readonly string[] _lista01;
        private readonly string[] _lista02;
        public Comparacao()
        {
            _lista01 = new string[500];
            _lista02 = new string[500];

            for(int i = 0; i < 500; i++)
            {
                _lista01[i] = Guid.NewGuid().ToString();
                _lista02[i] = Guid.NewGuid().ToString();
            }
        }

        public void Equals()
        {
            Console.WriteLine("Equals: ");
            var time = new Stopwatch();
            time.Start();

            bool x;
            for (int i = 0; i < 500; i++)
                x = _lista01[i].Equals(_lista02[i]);

            time.Stop();
            Console.WriteLine(time.Elapsed);
            Console.WriteLine();
        }

        public void Compare()
        {
            Console.WriteLine("Compare: ");
            var time = new Stopwatch();
            time.Start();

            bool x;
            for (int i = 0; i < 500; i++)
                x = string.Compare(_lista01[i], _lista02[i]) == 0;

            time.Stop();
            Console.WriteLine(time.Elapsed);
            Console.WriteLine();
        }

        public void Common()
        {
            Console.WriteLine("==: ");
            var time = new Stopwatch();
            time.Start();

            bool x;
            for (int i = 0; i < 500; i++)
                x = _lista01[i] == _lista02[i];

            time.Stop();
            Console.WriteLine(time.Elapsed);
            Console.WriteLine();
        }
    }
}
