namespace Lab3
{
    public class Green
    {
        public double Task1(int a, int b, int r, int n)
        {
            int count = 0;

            // code here
            int num;
            double x, y;
            for (num = 1; num <= n; num++)
            {
                if (double.TryParse(Console.ReadLine(), out x) && double.TryParse(Console.ReadLine(), out y))
                {
                    if ((x - a) * (x - a) + (y - b) * (y - b) <= r * r)
                    {
                        count += 1;
                    }
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
            double min = 1000000;
            for (int i = 1; i <= n; i++)
            {
                string inputx = Console.ReadLine();
                string inputy = Console.ReadLine();
                if (double.TryParse(inputx, out double x) && double.TryParse(inputy, out double y))
                {
                    double distance = Math.Sqrt(x * x + y * y);
                    if (distance < min)
                    {
                        min = distance;
                        length = distance;
                        index = i;
                    }
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
                string inputy = Console.ReadLine();
                if ((double.TryParse(inputx, out double x) && double.TryParse(inputy, out double y)) == false)
                {
                    break;
                }
                else
                { 
                    if (y >= 0 && x >= 0 && x <= Math.PI && y <= Math.Sin(x))
                    {
                        count++;
                    }
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
                string mark = Console.ReadLine();
                if (int.TryParse(mark, out int new_mark))
                {
                    if (labs > 0)
                    {
                        score += new_mark;
                        labs--;
                    }
                    else
                    {
                        score += 4 * new_mark;
                        cw--;
                    }
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
                    area = Math.Abs(a * a - b * b) * Math.PI;
                    break;
                case 3:
                    double p = (a + b + b) / 2.0;
                    area = Math.Sqrt(p * (p - a) * (p - b) * (p - b));
                    break;
                default:
                    break;
            }
            // end

            return area;
        }
    }
}
