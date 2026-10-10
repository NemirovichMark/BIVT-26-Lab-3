namespace Lab3
{
    public class Green
    {
        public double Task1(int a, int b, int r, int n)
        {
            int count = 0;
            for (int i = 0; i < n; i++)
            {
                string xv = Console.ReadLine();
                string yv = Console.ReadLine();

                double x = double.Parse(xv);
                double y = double.Parse(yv);
                double cx = x - a;
                double cy = y - b;
                double vec = Math.Sqrt(cx * cx + cy * cy);
                if (vec <= r)
                {
                    count += 1;
                }
            }
            return count;
        }
        public (int index, double length) Task2(int n)
        {
            int index = 0;
            double length = 1000000;

            for (int i = 1; i <= n; i++)
            {
                string xv = Console.ReadLine();
                string yv = Console.ReadLine();

                double x = double.Parse(xv);
                double y = double.Parse(yv);
 
                double vec = Math.Sqrt(x * x + y * y);
                
                if (vec < length)
                {
                    length = vec;
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
                
                string xv = Console.ReadLine();
                string yv = Console.ReadLine();

                bool xn = double.TryParse(xv, out double x);
                bool yn = double.TryParse(yv, out double y);
                if (!xn || !yn)
                {
                    break;
                }

                if (x >= 0 && x <= Math.PI && y >= 0 && y <= Math.Sin(x))
                {
                    count++;
                }
            }
            return count;

        }
        public int Task4(int labs, int cw)
        {
            int score = 0;
            
            while (labs > 0 || cw > 0)
            {
                string markk = Console.ReadLine();
                int mark = int.Parse(markk);
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
                    if (a > 0 && b > 0)
                    {
                        return area = a * b;
                    }
                    return 0;
                case 2:
                    if (b > a && a > 0 && b > 0)
                    {
                        return area = Math.PI * b * b - Math.PI * a * a;
                    }
                    return 0;

                case 3:
                    if (a > 0 && b > 0 && ((b * b - ((a * a) / 4.0) > 0)))
                    {
                        return area = 1.0 / 2.0 * a * Math.Sqrt(b * b - ((a * a) / 4.0));
                    }
                    return 0;

                default:
                    return 0;
            }

        }
    }
}
