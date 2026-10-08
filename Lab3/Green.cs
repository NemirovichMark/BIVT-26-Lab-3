using System;

namespace Lab3
{
    public class Green
    {
        //Task1
        public double Task1(int a, int b, int r, int n)
        {
            int count = 0;
            // code here
            for (int i = 0; i < n; i++)
            {
                //double x = Convert.ToDouble(Console.ReadLine());
                //double y = Convert.ToDouble(Console.ReadLine());
                double dx = x - a;
                double dy = y - b;
                double distSq = dx*dx + dy*dy;
                if (distSq <= r*r) count++;
            }
            // end
            return count;
        }

        //Task2
        public (int index, double length) Task2(int n)
        {
            int index = 0;
            double length = 0;
            // code here
            double minDist = double.MaxValue;
            for (int i = 1; i <= n; i++)
            {
                //double x = Convert.ToDouble(Console.ReadLine());
                //double y = Convert.ToDouble(Console.ReadLine());
                double d = Math.Sqrt(x*x + y*y);
                if (d < minDist)
                {
                    minDist = d;
                    index = i;
                    length = minDist;
                }
            }
            // end
            return (index, length);
        }

        //Task3
        public int Task3()
        {
            int count = 0;
            // code here
            while (true)
            {
                //bool okX = double.TryParse(Console.ReadLine(), out double x);
                //bool okY = double.TryParse(Console.ReadLine(), out double y);
                if (!okX || !okY) break;
                if (x >= 0 && x <= Math.PI && y >= 0 && y <= Math.Sin(x))
                    count++;
            }
            // end
            return count;
        }

        //Task4
        public int Task4(int labs, int cw)
        {
            int score = 0;
            // code here
            while (labs > 0 || cw > 0)
            {
                //int mark = Convert.ToInt32(Console.ReadLine());
                if (labs > 0)
                {
                    score += mark;
                    labs--;
                }
                else
                {
                    score += 4 * mark;
                    cw--;
                }
            }
            // end
            return score;
        }

        //Task5
        public double Task5(int a, int b, int type)
        {
            double answer = 0;
            // code here
            switch (type)
            {
                case 1:
                    answer = a * b;
                    break;
                case 2:
                    double R = Math.Max(a, b);
                    double r = Math.Min(a, b);
                    answer = Math.PI * (R*R - r*r);
                    break;
                case 3:
                    double h = Math.Sqrt(b*b - (a/2.0)*(a/2.0));
                    answer = 0.5 * a * h;
                    break;
                default:
                    answer = 0;
                    break;
            }
            // end
            return answer;
        }
    }
}
