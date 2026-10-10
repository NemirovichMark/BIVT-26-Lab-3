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
                string[] parts = Console.ReadLine().Split(' ');
                double x = double.Parse(parts[0]);
                double y = double.Parse(parts[1]);
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
            length = double.MaxValue;
            for (int i = 0; i < n; i++)
            {
                Console.WriteLine("Enter X: ");
                double x = double.Parse(Console.ReadLine());
                Console.WriteLine("Enter Y: ");
                double y = double.Parse(Console.ReadLine());
                double d = Math.Sqrt(x * x + y * y);
                if (d < length)
                {
                    length = d;
                    index = i + 1;
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
                Console.Write("Enter X: ");
                string sx = Console.ReadLine();
                if (!double.TryParse(sx, out double x))
                {
                    break;
                }
                Console.Write("Enter Y: ");
                string sy = Console.ReadLine();
                if (!double.TryParse(sy, out double y))
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
                Console.Write("input mark:");
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
                    area = a * b;
                    break;
                case 2:
                    area = Math.PI * Math.Abs(a * a - b * b);
                    break;
                case 3:
                    double h = Math.Sqrt(b * b - (a / 2.0) * (a / 2.0));
                    area = 0.5 * a * h;
                    break;
            }
            // end

            return area;
        }
    }
}