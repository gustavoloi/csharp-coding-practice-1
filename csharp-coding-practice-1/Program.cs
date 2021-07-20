/*
 TODO LIST
-CHECKS FOR AN EXISTING 0 IN ANY OTHER WAY. HOW IT IS RIGHT NOW IS NOT GOOD ENOUGH
-CHECK FOR MORE THAN 1 ZERO.
    -MAYBE COMPARE IF THE NUMBER IN THE CURRENT POSITION IS ALREADY A ZERO? THEN WHAT?
-DO ANYTHING WITH THE OTHER NUMBERS?
 */

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

            for (int i = 1; i < listSize; i++) //Loop to add items to the list based on the size typed
            {
                resultList.Add(rand.Next(10)); //100 indicates the range of values
            }

            return resultList;
        }


        public static List<int> ZeroesToCenter(List<int> arr)
        {
            List<int> displayList = new List<int>();
            int oldIndex;
            int newIndex = arr.Count / 2;
            int numberToArrange;
            int temp;
            Console.WriteLine("The target index is: " + newIndex.ToString());
            int index = 0;



            foreach (var item in arr.ToList())
            {

                if (item == 0) // Moves the position if the current number(item) is 0.
                {
                    oldIndex = index;
                    //temp = ;
                    arr.RemoveAt(newIndex);
                    arr.Insert(newIndex, 0);
                    //arr[newIndex] = 0;
                    //arr[index] = 1;
                    //arr.
                    // Get the current index of the item
                    //arr.
                }
                index++;
            }

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




            //Save this section for later, after the array is organized
            List < int > result = Result.ZeroesToCenter(arr);

            foreach (var item in arr)
                {
                    Console.Write("{0} ", item);
                }

            //foreach (var item in arr) //Display all the results
            //{
            //    Console.Write(item);
            //}

        }
    }
}
