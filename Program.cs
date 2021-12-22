using System;
using BenchmarkDotNet.Attributes;
using BenchmarkDotNet.Running;
using BenchmarkDotNet;


namespace AlgHomework_3
{
    public class Program
    {
        public static void Main(string[] args)
        {
            BenchmarkRunner.Run<BenchmarkClass>();

            
            // BenchmarkSwitcher.FromAssembly(typeof(Program).Assembly).Run(args);

        }
    }
}
