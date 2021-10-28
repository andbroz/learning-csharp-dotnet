﻿using System;
using System.Diagnostics;

namespace _02_donet_debuging
{
    class Program
    {
        static void Main(string[] args)
        {
           int result = Fibonacci(6);
           Console.WriteLine(result);
           Console.ReadKey(true);
        }
        static int Fibonacci(int n){

            Debug.WriteLine($"Enterign {nameof(Fibonacci)} method");
            Debug.WriteLine($"We are looking for the {n}th number");

            int n1 = 0;
            int n2 = 1;
            int sum = 0;


            for (int i=2; i<=n; i++) {
                sum = n1 + n2;
                n1 = n2;
                n2 = sum;
                Debug.WriteLineIf(sum == 1, $"Sum is 1, n1 is {n1}, n2 is {n2}");
            }
            Debug.Assert(n2 == 5, "The return value is not 5, and should be.");
            return n==0 ? n1 : n2;
        }
    }
}