using System;

namespace pointinpolygon_test
{
    public class Polygon
    {
        /// <summary>
        /// 判断平面坐标点是否在平面多边形内
        /// </summary>
        /// <param name="point">平面坐标点，格式为：x,y</param>
        /// <param name="polygon">平面多边形，格式为：x1,y1,x2,y2,x3,y3...</param>
        /// <returns>true：平面坐标点在平面多边形内，false：平面坐标点不在平面多边形内</returns>
        public static bool IsPointInPolygon(string point, string polygon)
        {
            var pointArray = point.Split(',');
            var polygonArray = polygon.Split(',');

            if (pointArray.Length != 2)
            {
                throw new ArgumentException("坐标点格式不符合标准", "point");
            }
            if (polygonArray.Length == 0 || polygonArray.Length % 2 != 0)
            {
                throw new ArgumentException("多边形格式不符合标准", "polygon");
            }

            var pointX = double.Parse(pointArray[0]);
            var pointY = double.Parse(pointArray[1]);
            double minX = double.MaxValue;
            double maxX = double.MinValue;
            double minY = double.MaxValue;
            double maxY = double.MinValue;

            for (int i = 0; i < polygonArray.Length; i = i + 2)
            {
                if (pointArray[0] == polygonArray[i] && pointArray[1] == polygonArray[i + 1])
                {
                    return true;
                }

                var x = double.Parse(polygonArray[i]);
                var y = double.Parse(polygonArray[i + 1]);
                minX = Math.Min(x, minX);
                maxX = Math.Max(x, maxX);
                minY = Math.Min(y, minY);
                maxY = Math.Max(y, maxY);
            }

            if (pointX < minX || pointX > maxX || pointY < minY || pointY > maxY)
            {
                return false;
            }

            bool inside = false;

            for (int i = 0, j = polygonArray.Length - 2; i < polygonArray.Length; j = i, i = i + 2)
            {
                var pointX1 = double.Parse(polygonArray[i]);
                var pointY1 = double.Parse(polygonArray[i + 1]);
                var pointX2 = double.Parse(polygonArray[j]);
                var pointY2 = double.Parse(polygonArray[j + 1]);

                if ((pointY1 > pointY) != (pointY2 > pointY) &&
                     pointX < (pointX2 - pointX1) * (pointY - pointY1) / (pointY2 - pointY1) + pointX1)
                {
                    inside = !inside;
                }
            }

            return inside;
        }
    }
}
