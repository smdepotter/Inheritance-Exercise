﻿using System;
using System.ComponentModel;

namespace Inheritance_Exercise
{
    class Program
    {
        static void Main(string[] args)
        {
            var stack = new Stack();

            stack.Push(1);
            stack.Push(2);
            stack.Push(3);

            Console.WriteLine(stack.Pop());
            Console.WriteLine(stack.Pop());

            stack.Clear();

            Console.WriteLine(stack.Pop());
        }
    }
}
