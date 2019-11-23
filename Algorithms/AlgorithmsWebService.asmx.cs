using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Services;

namespace Algorithms
{
    /// <summary>
    /// Summary description for AlgorithmsWebService
    /// </summary>
    [WebService(Namespace = "http://tempuri.org/")]
    [WebServiceBinding(ConformsTo = WsiProfiles.BasicProfile1_1)]
    [System.ComponentModel.ToolboxItem(false)]
    // To allow this Web Service to be called from script, using ASP.NET AJAX, uncomment the following line. 
    // [System.Web.Script.Services.ScriptService]
    public class AlgorithmsWebService : System.Web.Services.WebService
    {
        // push test
        //web servisler dışarıdan call edilebilir ve dışarıya dönülebilir formatta olmalı.
        #region simple test metots
        [WebMethod]
        public int Sum(int a, int b)
        {
            return a + b;
        }
        

        [WebMethod]
        public int SimpleArraySum(List<int> ar)  
        {
            int total = 0;
            foreach (int i in ar)
            {
                total = total + i;
            }
            return total;

        }
        #endregion

        [WebMethod(Description ="compare values of different arrays")]
        public List<int> CompareTheTriplets(List<int> firstGroup, List<int> secondGroup, int sizeOfArray)
        {
            List<int> test = new List<int>() { 0, 0 }; //değerini kullanacaksan init etmen gerekiyor.
            //int[] test = new int[2];

            for (int i = 0; i < sizeOfArray; i++)
            {
                if (firstGroup[i] > secondGroup[i])
                {
                    test[0]++;
                }
                else if (firstGroup[i] < secondGroup[i])
                {
                    test[1]++;
                }
            }
            return test;
        }

        [WebMethod]
        public void DiagonalDifference(int[][] a)
        {
            //web servis olmasına gerek yok
        }

        [WebMethod]
        public void StairCase(int n)
        {
            string[] arr = new string[4];
            for (int i = 0; i < 4; i++)
            {
                for (int j = 0; j < 4; j++)
                {
                    if(j < arr.Length)
                    {
                        arr[j] = " ";
                    }
                    else
                    {
                        arr[j] = "#";
                    }

                }
            }

            Console.WriteLine(string.Join(" ",arr));
        }

        //TODO: soap'ta request'e array geçmek.
        [WebMethod]
        public int[] IntArraySort(int[] arr)
        { //anla bunu.
            int[] arr2 = { 800, 11, 50, 771, 649, 770, 240, 9 };

            int temp = 0;

            for (int write = 0; write < arr.Length; write++)
            {
                for (int sort = 0; sort < arr.Length - 1; sort++)
                {
                    if (arr[sort] > arr[sort + 1])
                    {
                        temp = arr[sort + 1];
                        arr[sort + 1] = arr[sort];
                        arr[sort] = temp;
                    }
                }
            }

            for (int i = 0; i < arr.Length; i++)
                Console.Write(arr[i] + " ");

            return arr;

        }

    }
}
