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
                double x = Convert.ToDouble(Console.ReadLine());
                double y = Convert.ToDouble(Console.ReadLine());

                if ((x - a) * (x - a) + (y - b) * (y - b) <= r * r)
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
            for (int i = 1; i <= n; i++)
            {
                double x = Convert.ToDouble(Console.ReadLine());
                double y = Convert.ToDouble(Console.ReadLine());
                double d = Math.Sqrt(x * x + y * y);

                if (i == 1 || d < length)
                {
                    index = i;
                    length = d;
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
                double x, y;

                if (!double.TryParse(Console.ReadLine(), out x))
                {
                    break;
                }
                if (!double.TryParse(Console.ReadLine(), out y))
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
                int mark = Convert.ToInt32(Console.ReadLine());

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
                    area = (double)a * b;
                    break;
                case 2:
                    area = Math.PI * Math.Abs((double)a * a - (double)b * b);
                    break;
                case 3:
                    area = a / 2.0 * Math.Sqrt((double)b * b - a * a / 4.0);
                    break;
            }
            // end

            return area;
        }
    }
}