using System;
using System.Diagnostics;
using System.IO;
using Microsoft.Extensions.Configuration;

namespace TraceLevels
{
    class Program
    {
        static void Main(string[] args)
        {
            Trace.Listeners.Add(new TextWriterTraceListener(File.CreateText("trace.txt")));
            Trace.AutoFlush = true;

            double a = 5.5;
            Debug.WriteLine($"assigned {a} to variable a");
            Trace.WriteLine($"assigned {a} to variable a");

            double b = 4.5;
            Debug.WriteLine($"assigned {b} to variable b");
            Trace.WriteLine($"assigned {b} to variable b");

            double answer = Add(a, b);
            Debug.WriteLine($"Call add({a}, {b}) expected {a + b} received {answer}");
            Trace.WriteLine($"Call add({a}, {b}) expected {a + b} received {answer}");


            var builder = new ConfigurationBuilder()
            .SetBasePath(Directory.GetCurrentDirectory())
            .AddJsonFile("appsettings.json", optional: true, reloadOnChange: true);

            IConfigurationRoot configuration = builder.Build();

            var ts = new TraceSwitch(
                displayName: "PacketSwitch",
                description: "This switch is set via JSON config"
            );

            configuration.GetSection("PacketSwitch").Bind(ts);
            Trace.WriteLine(ts.TraceError, "Trace error");
            Trace.WriteLine(ts.TraceWarning, "Trace warning");
            Trace.WriteLine(ts.TraceInfo, "Trace info");
            Trace.WriteLine(ts.TraceVerbose, "Trace verbose");
        }

        static double Add(double a, double b)
        {
            return a + b;
        }
    }
}
