namespace Lab3
{
    public class Green
    {
        public double Task1(int a, int b, int r, int n)
        {
            int count = 0;
            for (int i = 1; i <= n; i++)
            {
                double x = double.Parse(Console.ReadLine());
                double y = double.Parse(Console.ReadLine());
                double p = (x - a);
                double v = (y - b);
                if ((p * p) + (v * v) <= (r * r))
                {
                    count += 1;
                }
 
            }
            
            return count;
        }
        public (int index, double length) Task2(int n)
        {
            int index = 0;
            double length = 0;
            double l = double.MaxValue;
            for (int i = 0; i < n; i++)
            {
                double x = double.Parse(Console.ReadLine());
                double y = double.Parse(Console.ReadLine());
                double d = Math.Sqrt(x * x + y * y);
                if (d < l)
                {
                    length = d;
                    index = i;
                }
            }

            return (index, length);
        }
        public int Task3()
        {
            int count = 0;

            while (true)
            {
                string x = Console.ReadLine();
                string y = Console.ReadLine();
                if (!double.TryParse(x, out double m) || !double.TryParse(y, out double k))
                {
                    break;
                }
                else
                {
                    m = double.Parse(x);
                    k = double.Parse(y);
                    if ((k >= 0) && (k <= Math.Sin(m)) && (m >= 0) && (m <= Math.PI))
                    {
                        count++;
                    }
                }
            }
            return count;
        }
        public int Task4(int labs, int cw)
        {
            int score = 0;

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

            return score;
        }
        public double Task5(int a, int b, int type)
        {
            double area = 0;

            switch (type)
            {
                case 1:

                    area = a * b;
                    break;

                case 2:

                    area = Math.PI * Math.Abs(a * a - b * b);
                    break;

                case 3:

                    double h = a / 2.0; 
                    double height = Math.Sqrt(b * b - h * h);
                    area = h * height;
                    break;

            }

            return area;
        }
    }
}
