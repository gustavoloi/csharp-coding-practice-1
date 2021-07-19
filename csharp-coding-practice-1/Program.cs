using System.CodeDom.Compiler;
using System.Collections.Generic;
using System.Collections;
using System.ComponentModel;
using System.Diagnostics.CodeAnalysis;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Runtime.Serialization;
using System.Text.RegularExpressions;
using System.Text;
using System;

namespace csharp_coding_practice_1
{

    class Result
    {

        public static List<int> RandomNumberGenerator(int listSize)
        {
            List<int> resultList = new List<int>();
            var rand = new Random();
            //var rtnlist = new List<double>();
            for (int i = 0; i < listSize; i++)
            {
                resultList.Add(rand.Next(100)); //100 indicates the range of values
            }

            return resultList;
        }


        public static List<int> ZeroesToCenter(List<int> arr)
        {
            List<int> displayList = new List<int>();




            return displayList;



        }

    }
    class Program
    {
        static void Main(string[] args)
        {
            // Move the 0 to the center of the array
            // Don't use other numbers



            int arrCount = Convert.ToInt32(Console.ReadLine().Trim());

            List<int> arr = new List<int>();

            for (int i = 0; i < arrCount; i++)
            {
                int arrItem = Convert.ToInt32(Console.ReadLine().Trim());
                arr.Add(arrItem);
            }

            foreach (var item in arr)
            {
                Console.WriteLine(item);
            }

            List<int> result = Result.ZeroesToCenter(arr);
            foreach(var item in result)
            {
                Console.WriteLine(item);
            }
        }
    }
}
