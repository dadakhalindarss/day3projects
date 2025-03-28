﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace stringbuilderdemo
{
    internal class Program
    {
        public static void equalsexamples()
        {
            string s1 = "hello";
            string s2 = "hello";
            string s3 = "kkk";
            Console.WriteLine($"{s1.Equals(s2)}");
            Console.WriteLine($"{s1 == s2}");
            s1 = s3;
            Console.WriteLine($"{s1 == s2}");
            Console.WriteLine($"{s1 == s3}");

        }

        public static void concat1(string s1)
        {
            string st = " world";
            s1 = s1 + st;
        }

        public static void concat2(StringBuilder sb1)
        {
            sb1.Append(" Everyone");
        }
        static void Main(string[] args)
        {
            //string is immutable means string i cannot change them but i can override them within themselves 
            //string is reference type and small string or capital String is same only same methods refflect 
            string orginal = "Raghavendra";
            string k = orginal.Substring(0, 6);// orginal string is undergone operation of substring
            Console.WriteLine($"The orginal string is {orginal} (HashCode: {orginal.GetHashCode()} ");// it has not changed and it is in some address
            Console.WriteLine($"The extracted string is {k} (HashCode: {k.GetHashCode()}");// it is extracted string 
                                                                                           // i can override the string and even after overriding it will change the address
                                                                                           //


            orginal = orginal.Substring(0, 5); //override i am doing but it will store it in new address 
            Console.WriteLine($"New String: {orginal} (HashCode: {orginal.GetHashCode()})");
            // so here lot of memory is wasted as we are created many string object it shoudl be like 
            // that one time we have to create the object and in that object only we have to append the data 

            string fname;
            string mname;
            string lname;

            Console.WriteLine("enter firstname :");
            fname = Console.ReadLine();
            Console.WriteLine("enter middle name :");
            mname = Console.ReadLine();
            Console.WriteLine("Enter last name ");
            lname = Console.ReadLine();

            string fullname = fname + " " + mname + " " + lname;

            Console.WriteLine($"{fullname}");
            string fullname2 = string.Concat(fname, " ", mname, " ", lname);
            Console.WriteLine($"{fullname2.ToUpper()}");
            Console.WriteLine("Enter new fname to be replced ");
            string newfname = Console.ReadLine();
            Console.WriteLine($"The new full name is {fullname.Replace(fname, newfname)}");

            StringBuilder sb = new StringBuilder("Mohan ");

            sb.Append("kumar ");
            sb.Append("Mishra");
            Console.WriteLine($"{sb.ToString()}");
            // another example showing string is immutable and string builder is mutable 
            string s1 = "Hello";
            StringBuilder sb2 = new StringBuilder("hai ");
            concat1(s1);
            concat2(sb2);
            Console.WriteLine($"{s1}--{sb2}");
            Console.ReadLine();

        }
    }
}
