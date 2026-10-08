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
                double d = Math.Abs((x - a) * (x - a)) + Math.Abs((y - b) * (y - b));

                if (d <= r * r)
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
            int a = 0;
            int b = 0;
            if ( n > 0) {
                double x1 = double.Parse(Console.ReadLine());
                double y1 = double.Parse(Console.ReadLine());
                double min = Math.Sqrt(Math.Abs((x1 - a) * (x1 - a)) + Math.Abs((y1 - b) * (y1 - b)));
                int indexT = 0;
                index = indexT;
                length = min;
                for (int i = 1; i < n; i++)
                {
                    indexT += 1;
                    double x = double.Parse(Console.ReadLine());
                    double y = double.Parse(Console.ReadLine());
                    double d = Math.Sqrt(Math.Abs((x - a) * (x - a)) + Math.Abs((y - b) * (y - b)));
                    if (d < min)
                    {
                        min = d;
                        length = d;
                        index = indexT;
                    }
                }
            }
            else {index = 0; length = 0;}
            // end

            return (index, length);
        }
        public int Task3()
        {
            int count = 0;

            // code here
            while (true)
            {
                string x = Console.ReadLine();
                if (!double.TryParse(x, out double resX))
                {
                    break;
                }
                string y = Console.ReadLine();
                if (!double.TryParse(x, out double resY))
                {
                    break;
                }
                if (resX >= 0 && resX <= Math.PI && resY >= 0 && resY <= Math.Sin(resX))
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
                int mark = int.Parse(Console.ReadLine());
                if (labs > 0)
                {
                    score += mark;
                    labs -= 1;
                }
                else
                {
                    score += 4 * mark;
                    cw -= 1;
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
                    double x = a / 2.0;
                    double h = Math.Sqrt(b * b - x * x);
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
