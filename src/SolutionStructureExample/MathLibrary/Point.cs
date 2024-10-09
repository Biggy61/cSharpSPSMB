﻿namespace App
{
    public class Point
    {
        public double x;
        public double y;

        public Point(double x, double y)
        {
            this.x = x;
            this.y = y;
        }

        public override string ToString()
        {
            return $"X = {x} | " +
                   $"Y = {y}";
        }
    }
}