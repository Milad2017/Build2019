﻿using SharedComponents;
using System;
using System.Reflection;

namespace HelloWordWriter
{
    class Program
    {
        static void Main(string[] args)
        {
            MyWriter writer = new MyWriter();

            if (writer.IsHelloWorldString(Assembly.GetExecutingAssembly().FullName))
            {
                Console.WriteLine(writer.GetHelloWorldString());
            }
            else
            {
                Console.WriteLine("Hello Generic World!");
            }
        }
    }
}
