using AlgorithmCaller.ServiceReference1;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlgorithmCaller.Generators
{
    public class ArrayGenerators
    {
        public static ArrayOfInt OneDimensionArrayGenrator()
        {
            //SOAP call ederken List'i ArrayOfInt'e çevirmen gerekti.
            ServiceReference1.ArrayOfInt arrayOfInt = new ServiceReference1.ArrayOfInt();

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

            /*for (int i = 0; i < sizeOfArray; i++)
            {
                int value = Convert.ToInt16(Console.ReadLine());
                arr.Add(value);
                Console.WriteLine(i+1 + ".nci eleman = " + value);
            }*/

            arrayOfInt.AddRange(list);

            return arrayOfInt;
        }

        public static int[] OneDimensionIntArrayGenrator()
        {
            Console.WriteLine("Array size ne olsun?");
            int sizeOfArray = Convert.ToInt16(Console.ReadLine());
            int[] arr = new int[sizeOfArray];

            for (int i = 0; i < sizeOfArray; i++)
            {
                int value = Convert.ToInt16(Console.ReadLine());
                arr[i] = value;
                Console.WriteLine(i + 1 + ".nci eleman = " + value);
            }

            return arr;
        }

        public static int[] OneDimensionRandomArrayGenerator(int arraySize, int minArrayValue, int maxArrayValue)
        {
            int[] arr = new int[arraySize];

            Random rand = new Random();


            for (int i = 0; i < arraySize; i++)
            {
                arr[i] = rand.Next(minArrayValue, maxArrayValue + 1);
            }

            Console.WriteLine(string.Join(" ", arr));

            return arr;
        }
    }
}
