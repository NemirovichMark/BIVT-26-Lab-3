using System;

namespace Lab3
{
    public class Green
    {
        // Задание 1
        public int Task1(int a, int b, int r, int n)
        {
            int answer = 0;
            //code here
            int count = 0;
            for (int i = 0; i < n; i++)
            {
                double x = double.Parse(Console.ReadLine() ?? "");
                double y = double.Parse(Console.ReadLine() ?? "");
                if ((x - a) * (x - a) + (y - b) * (y - b) <= r * r)
                    count++;
            }
            answer = count;
            //end
            return answer;
        }

        // Задание 2
        public (int, double) Task2(int n)
        {
            (int, double) answer = (0, 0.0);
            //code here
            int bestIndex = 0;
            double minDist = double.MaxValue;
            for (int i = 1; i <= n; i++)
            {
                double x = double.Parse(Console.ReadLine() ?? "");
                double y = double.Parse(Console.ReadLine() ?? "");
                double dist = Math.Sqrt(x * x + y * y);
                if (dist < minDist)
                {
                    minDist = dist;
                    bestIndex = i;
                }
            }
            answer = (bestIndex, minDist);
            //end
            return answer;
        }

        // Задание 3
        public int Task3()
        {
            int answer = 0;
            //code here
            int count = 0;
            while (true)
            {
                string sx = Console.ReadLine() ?? "";
                if (!double.TryParse(sx, out double x))
                    break;

                string sy = Console.ReadLine() ?? "";
                if (!double.TryParse(sy, out double y))
                    break;

                if (x >= 0 && x <= Math.PI && y >= 0 && y <= Math.Sin(x))
                    count++;
            }
            answer = count;
            //end
            return answer;
        }

        // Задание 4
        public int Task4(int labs, int cw)
        {
            int answer = 0;
            //code here
            int score = 0;
            while (labs > 0 || cw > 0)
            {
                int mark = int.Parse(Console.ReadLine() ?? "");
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
            answer = score;
            //end
            return answer;
        }

        // Задание 5
        public double Task5(int a, int b, int type)
        {
            double answer = 0;
            //code here
            switch (type)
            {
                case 1:
                    answer = a * b;
                    break;
                case 2:
                    answer = Math.PI * Math.Abs(a * a - b * b);
                    break;
                case 3:
                    double h = Math.Sqrt(b * b - (a / 2.0) * (a / 2.0));
                    answer = a * h / 2.0;
                    break;
            }
            //end
            return answer;
        }
    }
}
