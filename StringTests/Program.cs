using System;

namespace StringTests
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
            var comparacao = new Comparacao();
            comparacao.Equals();
            comparacao.Compare();
            comparacao.Common();
            
            var pequenosTextos = new ConcatenacaoPequenosTextos();
            pequenosTextos.Plus();
            pequenosTextos.Concat();
            pequenosTextos.Join();
            pequenosTextos.Interpolation();
            pequenosTextos.Builder();
            

            var grandesTextos = new ConcatenacaoGrandesTextos();
            grandesTextos.Plus();
            grandesTextos.Plus2();
            grandesTextos.Concat();
            grandesTextos.Join();
            grandesTextos.Builder();
            

            var comparacaoVazioNulo = new ComparacaoVazioNulo();
            comparacaoVazioNulo.IsNullOrEmpty();
            comparacaoVazioNulo.IsNullOrWhiteSpace();
            comparacaoVazioNulo.Common();
            */

            var formatacao = new Formatacao();
            formatacao.Format();
            formatacao.FormatToString();
            formatacao.StringInterpolation();

            Console.ReadKey();
        }
    }
}
