using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_1
{
    class Program
    {
        static void Main(string[] args)
        {

             Console.WriteLine("Введите коордионаты точек:");

            string[] lineStr = Console.ReadLine().Split();
            double[] line = ParseArrFromString(lineStr);
            Point p_1 = new Point(line);
            string[] lineStr_1 = Console.ReadLine().Split();
            double[] line_1 = ParseArrFromString(lineStr_1);
            Point p_2 = new Point(line_1);
            string[] lineStr_2 = Console.ReadLine().Split();
            double[] line_2 = ParseArrFromString(lineStr_2);
            Point p_3 = new Point(line_2);
            string[] lineStr_3 = Console.ReadLine().Split();
            double[] line_3 = ParseArrFromString(lineStr_3);
            Point p_4 = new Point(line_3);
            string[] lineStr_4 = Console.ReadLine().Split();
            double[] line_4 = ParseArrFromString(lineStr_4);
            Point p_5 = new Point(line_4);
            string[] lineStr_5 = Console.ReadLine().Split();
            double[] line_5 = ParseArrFromString(lineStr_5);
            Point p_6 = new Point(line_5);
            string[] lineStr_6 = Console.ReadLine().Split();
            double[] line_6 = ParseArrFromString(lineStr_6);
            Point p_7 = new Point(line_6);
            string[] lineStr_7 = Console.ReadLine().Split();
            double[] line_7 = ParseArrFromString(lineStr_7);
            Point p_8 = new Point(line_7);

            // Point p_1 = new Point(line[0], line[1], line[2]); // alt variant
            
            Console.WriteLine("Точки введены");
            Cube cub = new Cube(p_1, p_2, p_3, p_4, p_5, p_6, p_7, p_8);
            Console.WriteLine("Объем куба:");
            //cub.Volume(p_1, p_2);
            Console.WriteLine(cub.Volume(p_1, p_2));
            Console.WriteLine("Площадь основания:");
            /*cub.Square(p_1, p_2)*/;
            Console.WriteLine(cub.Square(p_1, p_2));
            Console.WriteLine("Спасибо");
            Console.ReadKey();
        }
     
        static double[] ParseArrFromString(string[] strArr)
        {
            double[] value = { GetDouble(strArr[0]), GetDouble(strArr[1]), GetDouble(strArr[2]) };
            return value;
        }

        static double GetDouble(string value)
        {
            ValidationDouble(value, out double outValue);
            return outValue;
        }

        static bool ValidationDouble(string value, out double outValue)
        {
            return double.TryParse(value, out outValue);
        }

    }
    public class Point
    {
        public double x { get;}
        public double y { get;}
        public double z { get;}

        public Point(double x, double y, double z)
        {
            this.x = x;
            this.y = y;
            this.z = z;
        }

        public Point(double[] ar)
        {
            if (ar.Length != 3)
                throw new Exception("У точки 3 координаты");

            x = ar[0];
            y = ar[1];
            z = ar[2];
        }



    }
    
   
   public class Cube 
    {
        public Point Point_1 { get; }
        public Point Point_2 { get; }
        public Point Point_3 { get; }
        public Point Point_4 { get; }
        public Point Point_5 { get; }
        public Point Point_6 { get; }
        public Point Point_7 { get; }
        public Point Point_8 { get; }

        public Cube(Point p1, Point p2, Point p3, Point p4, Point p5, Point p6, Point p7, Point p8)
        {
            this.Point_1 = p1;
            this.Point_2 = p2;
            this.Point_3 = p3;
            this.Point_4 = p4;
            this.Point_5 = p5;
            this.Point_6 = p6;
            this.Point_7 = p7;
            this.Point_8 = p8;
        }

     


        public double Volume(Point p1, Point p2)
        {
                return Math.Pow(GetLength(p1, p2), 3);
        }

        public double Square(Point p1, Point p2)
        {
                return Math.Pow(GetLength(p1, p2), 2);
        }


        private double GetLength(Point p1, Point p2)
        {
            if ((p1.x == p2.x && p1.y == p2.y) || (p1.x == p2.x && p1.z == p2.z) || (p1.y == p2.y && p1.z == p2.z))
            {
                return Math.Sqrt(Math.Pow(p1.x - p2.x, 2) + Math.Pow(p1.y - p2.y, 2) + Math.Pow(p1.z - p2.z, 2));
            }
            else
            {
                  throw new Exception("Эти точки не соседние!");
            }

        }

        //public bool Get()
        //{
        //    if ()
        //        return true;
        //    else
        //    {
        //        return false;
        //    }
        //}


    }
}
