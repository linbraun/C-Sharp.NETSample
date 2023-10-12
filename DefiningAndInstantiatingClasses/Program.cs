﻿#region Using directives

using System;
using System.Collections.Generic;
using System.Text;

#endregion

namespace DefiningAndInstantiatingClasses
{
    class Program
    {
        static void Main(string[] args)
        {
            Point origin = new Point();
            Point bottomRight = new Point(1366, 768);   //changed another to new
            double distance = origin.DistanceTo(bottomRight);
            Console.WriteLine("Distance is: {0}", distance);
            Console.WriteLine("Number of Point objects: {0}", Point.ObjectCount());
        }
    }
    class Point
    {
        private int x, y;
        private static int objectCount = 0;  //changed private to public static
        public Point()  //removed void type
        {
            this.x = -1;
            this.y = -1;
            objectCount++;
        }
        public Point(int x, int y)
        {
            this.x = x;
            this.y = y;
            objectCount++;
        }
        public double DistanceTo(Point other)   //changed private to public
        {
            int xDiff = this.x - other.x;
            int yDiff = this.y - other.y;
            double distance = Math.Sqrt((xDiff * xDiff) + (yDiff * yDiff));
            return distance;
        }
        public static int ObjectCount()
        {
            return objectCount;
        }
    }
}