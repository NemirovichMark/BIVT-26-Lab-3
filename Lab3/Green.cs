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
                double d = Math.Abs(Math.Pow(x - a, 2)) + Math.Abs(Math.Pow(y - b, 2));

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
            double min = 99999999999999999999999999999999999999999999.0;
            int indexT = 0;
            for (int i = 0; i < n; i++)
            {
                indexT += 1;
                double x = double.Parse(Console.ReadLine());
                double y = double.Parse(Console.ReadLine());
                double d = Math.Sqrt(Math.Abs(Math.Pow(x - a, 2)) + Math.Abs(Math.Pow(y - b, 2)));
                if (d < min)
                {
                    min = d;
                    length = d;
                    index = indexT;
                }
            }
            // end

            return (index, length);
        }
        public int Task3()
        {
            int count = 0;

            // code here
            
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
            if (type == 1)
            {
                area = a * b;
            }
            else if (type == 2)
            {
                area = Math.PI * (a * a - b * b);
            }
            else
            {
                area = (a + b) / 2;
            }
            // end

            return area;
        }
    }
}
