// See https://aka.ms/new-console-template for more information
using System;
using System.Collections.Generic;
using System.Linq;

namespace MyApp // Note: actual namespace depends on the project name.
{
    public class Program
    {
        public static void Main(string[] args)
        {
            byte b = 5; // 1 byte
            sbyte c = 5; // 1 byte

            short s = 5; // 2 byte
            ushort us = 5; // 2 byte

            Int16 i16 = 2; // 2 byte
            int i = 2; // 4 byte
            Int32 i32 = 2; // 4 byte
            Int64 i64 = 2; // 8 byte

            uint  ui = 2;
            long l = 4;
            ulong ul = 4;
            

            float f = 5;
            double d = 5;
            decimal de = 5;

            char ch = 'c';
            string str = "Zikriye";

            bool b1 = true;
            bool b2 = false;

            DateTime dt = DateTime.Now;

            Console.WriteLine(dt);

            object o1 = "x";
            object o2 = 'y';
            object o3 = 4;
            object o4 = 4.2;

            bool boll = 10>2;

            string str20 = "20";
            int int20 = 20;
            string yenideger = str20 + int20.ToString();

            Console.WriteLine(yenideger);
            
            int int21 = int20 + Convert.ToInt32(int20);
            Console.WriteLine(int21);

            int int22 = int20  + int.Parse(str20);


            string dateTime = DateTime.Now.ToString("dd.MM.yyyy");
            Console.WriteLine(dateTime);






        }
    }
}