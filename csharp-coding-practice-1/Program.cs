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
            List<int> resultList = new List<int>(); //Creates the list to be used for storing the array
            var rand = new Random(); //Create a random object
            resultList.Add(0); //Makes sure at least one "0" is in the list

            for (int i = 0; i < listSize; i++) //Loop to add items to the list based on the size typed
            {
                resultList.Add(rand.Next(10)); //100 indicates the range of values
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

            List<int> arr = new List<int>();
            arr = Result.RandomNumberGenerator(10);


            foreach (var item in arr) //Display all the results
            {
                Console.WriteLine(item);
            }


            //Save this section for later, after the array is organized
            //List<int> result = Result.ZeroesToCenter(arr);
            //foreach(var item in result)
            //{
            //    Console.WriteLine(item);
            //}
        }
    }
}
