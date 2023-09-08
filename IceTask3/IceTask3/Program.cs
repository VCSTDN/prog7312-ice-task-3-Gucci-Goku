using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IceTask3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            
            //int[] ex = { 1, -3, -6, 2, 6, };
            //string str = "Map Jack Lap";
            //int index = 0;
            //string curr = "";
            //powerSet(str, index, curr);
            //remove(ex);
            //for (int i = 0; i < ex.Length; i++)
            //{

            //    Console.WriteLine(ex[i]);
            //}
            Console.ReadLine();
        }


        //static void powerSet(String str, int index, String curr)

        //{
        //    int n = str.Length;

        //    // base case
        //    if (index == n)
        //    {
        //        Console.WriteLine(curr);
        //        return;
        //    }

        //    // Two cases for every character
        //    // (i) We consider the character
        //    // as part of current subset
        //    // (ii) We do not consider current
        //    // character as part of current
        //    // subset
        //    powerSet(str, index + 1, curr + str[index]);
        //    powerSet(str, index + 1, curr);

        //}


        //static void remove(int[] arr)
        //{
        //    int n = arr.Length;

        //    int pos = 0;
        //    for (int i = 0; i < n; i++)
        //    {
        //        if (arr[i] >= 0)
        //        {
        //            arr[pos] = arr[i];
        //            pos++;
        //        }
        //    }

        //}


        static void storeRandom(int[] arr, int n)
        {
            Random ran = new Random();

            int count = 15;

            // Create an array with count elements.
            int[] numbers = new int[count];

            // Loop over each index
            for (int i = 0; i < count; i++)
            {
                // Generate and store a random number at current index
                numbers[i] = ran.Next(1, 11);
            }

            bool[] check = new bool[n];

            for (int i = 0; i < n; i++)
            {

               
                if (check[i] == true)
                    continue;

                int counts = 1;
                for (int j = i + 1; j < n; j++)
                {
                    if (arr[i] == arr[j])
                    {
                        check[j] = true;
                        count++;
                    }
                }
                Console.WriteLine(arr[i] + " " + count);
            }
        }

        //for (int i = 0; i < numbers.Length; i++)
        //{
        //    Console.WriteLine(numbers[i]);
        //}

    }

    }

      
