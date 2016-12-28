using System;

namespace pointinpolygon_test
{
    class Program
    {
        static void Main(string[] args)
        {
            var polygon1 = "113.612361,34.809969,113.639581,34.770364,113.710471,34.775082,113.701196,34.809484";
            var polygon2 = "113.705058,34.808841,113.728968,34.762533,113.682153,34.739195,113.784628,34.736579,113.756814,34.78411";
            var pointA = "113.612361,34.809969";
            var pointB = "113.710471,34.775082";
            var pointC = "113.705058,34.808841";
            var pointD = "113.682153,34.739195";
            var pointE = "113.756814,34.78411";
            var pointF = "113.720639,34.770524";
            var pointG = "113.672282,34.787513";
            var pointH = "113.744637,34.762767";

            Console.WriteLine("polygon1:");
            Console.WriteLine("A :" + Polygon.IsPointInPolygon(pointA, polygon1));
            Console.WriteLine("B :" + Polygon.IsPointInPolygon(pointB, polygon1));
            Console.WriteLine("C :" + Polygon.IsPointInPolygon(pointC, polygon1));
            Console.WriteLine("D :" + Polygon.IsPointInPolygon(pointD, polygon1));
            Console.WriteLine("E :" + Polygon.IsPointInPolygon(pointE, polygon1));
            Console.WriteLine("F :" + Polygon.IsPointInPolygon(pointF, polygon1));
            Console.WriteLine("G :" + Polygon.IsPointInPolygon(pointG, polygon1));
            Console.WriteLine("H :" + Polygon.IsPointInPolygon(pointH, polygon1));

            Console.WriteLine("");
            Console.WriteLine("polygon2:");
            Console.WriteLine("A :" + Polygon.IsPointInPolygon(pointA, polygon2));
            Console.WriteLine("B :" + Polygon.IsPointInPolygon(pointB, polygon2));
            Console.WriteLine("C :" + Polygon.IsPointInPolygon(pointC, polygon2));
            Console.WriteLine("D :" + Polygon.IsPointInPolygon(pointD, polygon2));
            Console.WriteLine("E :" + Polygon.IsPointInPolygon(pointE, polygon2));
            Console.WriteLine("F :" + Polygon.IsPointInPolygon(pointF, polygon2));
            Console.WriteLine("G :" + Polygon.IsPointInPolygon(pointG, polygon2));
            Console.WriteLine("H :" + Polygon.IsPointInPolygon(pointH, polygon2));

            Console.ReadLine();
        }
    }

}
