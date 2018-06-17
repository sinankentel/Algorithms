using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AlgorithmCaller.ServiceReference1;
using AlgorithmCaller.Generators;

namespace AlgorithmCaller
{
    class Program
    {
        static void Main(string[] args)
        {

            //Console.WriteLine("sonuç= {0}", CallerClass.SumHackerRank());
            //Console.WriteLine("sonuç= {0}", CallerClass.SimpleArraySumHackerRank());
            //Console.WriteLine("sonuç= {0}", CallerClass.CompareTheTripletsHackerRank());
            //Console.WriteLine(string.Join(" ", CallerClass.CompareTheTripletsHackerRank()));
            //CallerClass.PlusMinusHackerRank();
            //ArrayGenerators.OneDimensionRandomArrayGenerator(15, -1, 2);
            //Console.WriteLine(CallerClass.DiagonalDifferenceHackerRank());
            //CallerClass.ArraySort(ArrayGenerators.OneDimensionRandomArrayGenerator(5, 0, 10));

            CallerClass.StaircaseHackerRank();


            Console.ReadLine();

        }
    }
}
