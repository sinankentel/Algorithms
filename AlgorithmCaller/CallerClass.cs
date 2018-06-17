using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AlgorithmCaller.ServiceReference1;
using AlgorithmCaller.Generators;

namespace AlgorithmCaller
{
    class CallerClass
    {
        public static int SumService()
        {
            var client = new AlgorithmsWebServiceSoapClient();
            int sonuc = client.Sum(3, 6);
            return sonuc;

        }

        public static int SumHackerRank()
        {
            var client = new AlgorithmsWebServiceSoapClient();

            int val1 = Convert.ToInt32(Console.ReadLine());
            int val2 = Convert.ToInt32(Console.ReadLine());

            return client.Sum(val1, val2);
        }

        public static int SimpleArraySumHackerRank()
        {
            var client = new AlgorithmsWebServiceSoapClient();

            return client.SimpleArraySum(ArrayGenerators.OneDimensionArrayGenrator());

        }

        public static List<int> CompareTheTripletsHackerRank()
        {
            //SOAP call ederken List'i ArrayOfInt'e çevirmen gerekti.
            var client = new AlgorithmsWebServiceSoapClient();
            ArrayOfInt arrayOfInt1 = new ArrayOfInt();
            ArrayOfInt arrayOfInt2 = new ArrayOfInt();

            Console.WriteLine("Array size'ları ne olsun?");
            int sizeOfArrays = Convert.ToInt16(Console.ReadLine());

            Console.WriteLine("1.array'in elemanlarını girin.");

            List<int> firstList = new List<int>(); //objeyi yaratman gerekiyor.
            List<int> secondList = new List<int>();

            for (int i = 0; i < sizeOfArrays; i++)
            {
                int value1 = Convert.ToInt16(Console.ReadLine());
                firstList.Add(value1);
                int value2 = Convert.ToInt16(Console.ReadLine());
                secondList.Add(value2);
            }

            //Console.WriteLine(firstList); --> objeyi yazar, elemanlarını değil.

            arrayOfInt1.AddRange(firstList);
            arrayOfInt2.AddRange(secondList);

            //bool isArrayListCorrect = false;

            //TextWriter textWriter = new StreamWriter(@System.Environment.GetEnvironmentVariable("OUTPUT_PATH"), true);
            //int[] a = Array.ConvertAll(Console.ReadLine().Split(' '), aTemp => Convert.ToInt32(aTemp));

            return client.CompareTheTriplets(arrayOfInt1, arrayOfInt2, sizeOfArrays);
        }

        
        public static int DiagonalDifferenceHackerRank()
        {
            Console.WriteLine("Array size'ı ne olsun?");
            int sizeOfArrays = Convert.ToInt16(Console.ReadLine());

            Console.WriteLine("array'in elemanlarını gir");

            int[,] arr = new int[sizeOfArrays, sizeOfArrays];

            for (int i = 0; i < sizeOfArrays; i++)
            {
                for (int j = 0; j < sizeOfArrays; j++)
                {
                    int value = Convert.ToInt16(Console.ReadLine());
                    arr[i,j] = value;
                }
            }

            int diagonal1 = 0;
            int diagonal2 = 0;

            for (int i = 0; i < sizeOfArrays; i++)
            {
                diagonal1 += arr[i,i];
            }

            for (int i = 0; i < sizeOfArrays; i++)
            {
                diagonal2 += arr[i, ((sizeOfArrays - 1) - i)];
            }

            int diff = 0;

            diff = ((diagonal1 - diagonal2) > 0) ? (diagonal1 - diagonal2) : ((diagonal1 - diagonal2) * (-1));

            return diff;

        }

        public static void PlusMinusHackerRank()
        {
            var client = new AlgorithmsWebServiceSoapClient();

            //CallerClass.OneDimensionArrayGenrator();

            Console.WriteLine("Array size ne olsun?");
            int sizeOfArray = Convert.ToInt16(Console.ReadLine());
            //int[] arr = new int[sizeOfArray];

            List<int> list = new List<int>();

            string allItems = Console.ReadLine();
            string[] itemsArray = allItems.Split(' ');

            for (int i = 0; i < sizeOfArray; i++)
            {
                list.Add(Convert.ToInt16(itemsArray[i]));
            }

            int positiveNumberCount = 0;
            int negativeNumberCount = 0;
            int zeroNumberCount = 0;

            foreach (int item in list)
            {
                if (item > 0) { positiveNumberCount++; }
                else if (item < 0) { negativeNumberCount++; }
                else { zeroNumberCount++; }
            }

            float x = (float)(positiveNumberCount) / (list.Count);
            float y = (float)(negativeNumberCount) / (list.Count);
            float z = (float)(zeroNumberCount) / (list.Count);

            Console.WriteLine(x);
            Console.WriteLine(y);
            Console.WriteLine(z);
        }

        public static void StaircaseHackerRank()
        {
            var client = new AlgorithmsWebServiceSoapClient();

            int n = Convert.ToInt16(Console.ReadLine());

            client.StairCase(n);

        }

        public static int[] ArraySort(int[] arr)
        {
            Array.Sort(arr);
            return arr;

        }


    }
}
