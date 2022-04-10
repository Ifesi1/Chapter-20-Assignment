using System;

namespace Question_5
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
        }
    }
    public abstract class Shape
    {
        public static int width;
        public int heigth;

        public int CalculateSurface()
        {
            heigth = 12;
            width = 7;
            int calc = width * heigth;
            return calc;

        }
    }
    
    public class Rectangle:Shape
    {
        public  int CalculateSurface()
        {
            heigth = 9;
            width = 17;
            int calc = (int)Math.BigMul(width, heigth);
            
            return calc;
        }
    }
    public class Triangle:Shape
    {
        public override int CalculateSurface()
        {
            heigth = 9;
            width = 5;
            int calc = (int)Math.BigMul(width/2, heigth);
            return calc;
        }
    }
    public class Circle
    {
        public int heigth;
        public int width;
        
        public abstract int CaculateSurface()
        {
            heigth = width =5;
            int calc = (int)Math.BigMul(width, heigth);
            return calc;
        }
    }
}
