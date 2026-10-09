namespace Lab3
{
    public class Green
    {
        public double Task1(int a, int b, int r, int n)
        {
            int count = 0;

            // code here
            double rsq = r * r;
            for(int i = 1; i <= n; i++) 
            {
                if (!double.TryParse(Console.ReadLine(), out double x))
                {
                    i--;
                    continue;
                }
                if (!double.TryParse(Console.ReadLine(), out double y))
                {
                    i--;
                    continue;
                }
                double dx = x - a;
                double dy = y - b;
                if ((dx * dx) + (dy * dy) <= rsq) { count++; }

            }
            // end
            Console.WriteLine($">{count}");
            return count;
        }
        public (int index, double length) Task2(int n)
        {
            int index = 0;
            double length = 999999;

            // code here
            //double mn = 9999;
            for (int i = 1; i <= n; i++)
            {
                double.TryParse(Console.ReadLine(), out double x);
                double.TryParse(Console.ReadLine(), out double y);
                if (Math.Sqrt((x * x) + (y * y)) < length)
                {
                    length = Math.Sqrt((x * x) + (y * y)); index = i;
                }

            }
            if (n == 0) length = 0;
            // end

            return (index, length);
        }
        public int Task3()
        {
            int count = 0;

            // code here
            while (true)
            {
                if (!double.TryParse(Console.ReadLine(), out double x)) break;
                if (!double.TryParse(Console.ReadLine(), out double y)) break;
                if(x>=0 && x<=Math.PI && y>=0 && y <=Math.Sin(x)) count++; 
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
                int.TryParse(Console.ReadLine(), out int mark);
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
                case (1):
                    area = a * b;
                    break;
                case (2):
                    area = Math.PI * Math.Abs(a * a - b * b);
                    break;
                case (3):
                    double h = Math.Sqrt(b * b - (a * a / 4.0));
                    area = 0.5 * a * h;
                    break;
                

            }
            // end

            return area;
        }
    }
}
