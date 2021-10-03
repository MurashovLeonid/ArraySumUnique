using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.IO;
using System.Threading.Tasks;
using System.Linq;
using System.Threading;
using System.Threading.Channels;


namespace ConsoleGeneralTrain
{
    class ArrayAnalyserSumUnique
    {
        public static int[] AnalysisMeth(int[] array1, int[] array2)
        {
            var a = (from i in array1 orderby i select i);
            var b = (from i in array2 orderby i select i);
            List<int> listA = new List<int>();
            List<int> listB = new List<int>();
            List<int> resultList = new List<int>();
            foreach (var val in a)
            {
                listA.Add(val);
            }
            foreach (var val in b)
            {
                listB.Add(val);
            }

            for (int i = 0; i <= listA.Count() - 1; i++)
            {
                for (int j = 0; j <= listB.Count() - 1; j++)
                {
                    if (listA[i] == listB[j])
                    {
                        listA.Remove(listA[i]);
                        listB.Remove(listB[j]);
                    }
                }
            }
            for (int i = 0; i <= listB.Count() - 1; i++)
            {
                for (int j = 0; j <= listA.Count() - 1; j++)
                {
                    if (listB[i] == listA[j])
                    {
                        listA.Remove(listB[i]);
                        listB.Remove(listA[j]);
                    }
                }
            }

            foreach (var val in listA)
            {
                resultList.Add(val);
            }
            foreach (var val in listB)
            {
                resultList.Add(val);
            }

           

            int[] resultArray = new int[resultList.Count()];
            for (int i = 0; i <= resultArray.Length - 1; i++)
            {
                resultArray[i] = resultList[i];
            }

            return resultArray;
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            int[] testArray1 = { 1, 2, 2, 5,5,5,6,7,9,0};
            int[] testArray2 = { 1,2,4,5,6,2,2,5,5,7,11,12,3 };
            var result = ArrayAnalyserSumUnique.AnalysisMeth(testArray1, testArray2);
            foreach (var val in result)
            {
                Console.WriteLine(val);
            }


        }
    }
}


