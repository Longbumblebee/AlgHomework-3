using System;
using System.Collections.Generic;
using System.Text;
using BenchmarkDotNet.Attributes;
using BenchmarkDotNet.Running;

namespace AlgHomework_3
{
    [MemoryDiagnoser]
    [RankColumn]
    public class BenchmarkClass
    {
        public const int SIZE = 1_000_000;
        public PointClassDouble[] pointClassDoubleArray = new PointClassDouble[SIZE];
        public PointStructDouble[] pointStructDoubleArray = new PointStructDouble[SIZE];

        public BenchmarkClass()
        {
            Random rnd = new Random();
            for (int i = 0; i < SIZE; i++)
            {
                int x = rnd.Next(1, 100);
                int y = rnd.Next(1, 100);
                pointClassDoubleArray[i] = new PointClassDouble(x, y);
                pointStructDoubleArray[i] = new PointStructDouble(x, y);
            }
        }

        [Benchmark]
        public void BechmarkClassDouble()
        {
            for (int i = 0; i < SIZE - 1; i++)
                PointClassDouble.PointDistance(pointClassDoubleArray[i], pointClassDoubleArray[i + 1]);
        }

        [Benchmark]
        public void BechmarkStructDouble()
        {
            for (int i = 0; i < SIZE - 1; i++)
                PointStructDouble.PointDistance(pointStructDoubleArray[i], pointStructDoubleArray[i + 1]);
        }

    }
}