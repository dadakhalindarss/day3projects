﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.NetworkInformation;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace Arraysdemo
{
    internal class Program
    {
        static void PrintArray(int[] arr)
        {
            Console.WriteLine("\nprinting the array ...");
            for (int i = 0; i < arr.Length; i++)
            {
                Console.Write($"{arr[i]}  ");
            }
        }
        static void Main(string[] args)
        {

            int[] aa1 = new int[] { 12, 34, 56, 33, 45, 90 };//infinite array no limit
            int[] aa2 = new int[4] { 12, 34, 56, 90 };// finite array as 4 is limit
            // in both the above arrays i am declaring also and intilizing also there only 
            int[] aa3 = new int[4];// only declaring array array is there but empty 
            string[] names = new string[] { "ravi", "kumar", "sita" };
            char[] chars = new char[] { 'A', '*', 'D' };
            var names2 = new string[] { "ravi", "kumar", "sita" };

            int[] a = new int[5];//declared but not read or intilized 
            //so now reading the array i want to do 
            Console.WriteLine("Enter values in array :");

            int i, j, sum = 0;
            for (i = 0; i < a.Length; i++)
            {
                Console.Write($"Enter element {i + 1}:");
                a[i] = Convert.ToInt32(Console.ReadLine());
            }
            PrintArray(a);
            Console.Write("\n finding sum of elements in array :");
            for (i = 0; i < a.Length; i++)
            {
                sum = sum + a[i];
            }
            Console.Write($"{sum}");
            //use another loop to print the array which is foreach loop which is read only loop means i cannot modify the array if i am using 
           // for each loop but using for loop i can modify the array also let us see by putting some code in above programming whic i am doing
            

             Console.WriteLine("\n printing the array using for each loop");
            foreach (int ele in a)
            {
                Console.Write($"{ele}  ");
            }
            // modifying the array
            Console.WriteLine("\n Modifying array using for loop");
            for (i = 0; i < a.Length; i++)
            {
                a[i] = a[i] * 3;
            }
            PrintArray(a);

            //searching an element in the array
            Console.WriteLine("\n Enter element to be searched in the array..");
            int ele1 = Convert.ToInt32(Console.ReadLine());
            int flag = 0;
            for (i = 0; i < a.Length; i++)
            {
                if (a[i] == ele1)
                {
                    Console.WriteLine($"The element {ele1} is found at position {i + 1}");
                    flag = 1;
                    break;
                }

            }
            if (flag == 0)
            {
                Console.WriteLine($"The element {ele1} is not found in the array..");
            }
            // sorting the array
              Console.WriteLine("\n Sorting the array ..");
            for (i = 0; i < a.Length - 1; i++)
            {
                for (j = i + 1; j < a.Length; j++)
                {
                    if (a[i] > a[j])
                    {
                        int temp;
                        temp = a[i];
                        a[i] = a[j];
                        a[j] = temp;
                    }
                }
            }
            Console.WriteLine("\n after sorting printing the array..");
            PrintArray(a);
            Console.ReadLine();
        }
    }
    }
