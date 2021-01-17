using System;
using System.ComponentModel;
using System.Diagnostics;
using System.IO;

namespace DeliberateErrorDebug
{
    class Program
    {
        static void Main(string[] args)
        {
            Trace.Listeners.Add(new TextWriterTraceListener(File.CreateText("log.txt")));
            Trace.AutoFlush = true;

            double a = 4.5;
            Trace.WriteLine($"Variable assignment a = {a}");

            double b = 2.5;
            Trace.WriteLine($"Variable assignment b = {b}");

            double answer = Add(a, b);
            Trace.WriteLine($"calculation expects {a + b} function returned {answer}");

            Console.WriteLine($"{a} + {b} = {answer}");
            Console.ReadLine();
        }

        static double Add(double a, double b)
        {
            return a * b;
        }
    }
}
