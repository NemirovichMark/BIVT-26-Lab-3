using System.Security.Cryptography.X509Certificates;

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
                double x = double.Parse(Console.ReadLine());
                double y = double.Parse(Console.ReadLine());
                double rast = (a - x) * (a - x) + (b - y) * (b - y);
                if (rast <= r * r) count++;
            }
            // end

            return count;
        }
        public (int index, double length) Task2(int n)
        {
            int index = 0;
            double length = 0;

            // code here
            for (int i = 1; i <= n; i++)
            {
                double x = double.Parse(Console.ReadLine());
                double y = double.Parse(Console.ReadLine());
                double rast = Math.Sqrt(x * x + y * y);
                if (i == 1 || rast < length)
                {
                    length = rast;
                    index = i;
                }
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
                string inputx = Console.ReadLine();
                double x;
                if (!double.TryParse(inputx, out x)) break;

                string inputy = Console.ReadLine();
                double y;
                if (!double.TryParse(inputy, out y)) break;

                if (x >= 0 && x <= Math.PI && y >= 0 && y <= Math.Sin(x)) count++;

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
                int mark = int.Parse(Console.ReadLine());
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
                    area = h * a / 2;
                    break;
            }
            // end

            return area;
        }
    }
}
