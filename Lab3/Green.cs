using System.Globalization;

namespace Lab3
{
    public class Green
    {
        public double Task1(int a, int b, int r, int n)
        {
            int count = 0;

            // code here
            for (int i = 0; i < n; i++)
            {
                double x = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                double y = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

                double dx = x - a;
                double dy = y - b;
                double distSq = dx * dx + dy * dy;
                double rSq = r * r;

                if (distSq <= rSq + 1e-9)
                {
                    count++;
                }
            }
            // end

            return count;
        }
        public (int index, double length) Task2(int n)
        {
            int index = 0;
            double length = 0;

            // code here
            double minLength = double.MaxValue;
            int bestIndex = 0;

            for (int i = 1; i <= n; i++)
            {
                double x = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                double y = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

                double dist = Math.Sqrt(x * x + y * y);

                if (dist < minLength)
                {
                    minLength = dist;
                    bestIndex = i;
                }
            }

            if (n > 0)
            {
                index = bestIndex;
                length = minLength;
            }
            // end

            return (index, length);
        }
        public int Task3()
        {
            int count = 0;

            // code here
            while (true)
            {
                string inputX = Console.ReadLine();
                if (!double.TryParse(inputX, NumberStyles.Float, CultureInfo.InvariantCulture, out double x))
                {
                    break;
                }

                string inputY = Console.ReadLine();
                if (!double.TryParse(inputY, NumberStyles.Float, CultureInfo.InvariantCulture, out double y))
                {
                    break;
                }

                if (x >= 0 && x <= Math.PI && y >= 0 && y <= Math.Sin(x))
                {
                    count++;
                }
            }
            // end

            return count;
        }
        public int Task4(int labs, int cw)
        {
            int score = 0;

            // code here
            while (labs > 0 || cw > 0)
            {
                int mark = int.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

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
        public double Task5(int a, int b, int type)
        {
            double area = 0;

            // code here
            switch (type)
            {
                case 1: 
                    area = a * b;
                    break;
                case 2: 
                    area = Math.PI * Math.Abs(a * a - b * b);
                    break;
                case 3: 
                    double h = Math.Sqrt(b * b - (a / 2.0) * (a / 2.0));
                    area = 0.5 * a * h;
                    break;
                default:
                    area = 0;
                    break;
            }
            // end

            return area;
        }
    }
}