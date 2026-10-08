using System.Diagnostics;

namespace Lab3
{
    public class Green
    {
        public double Task1(int a, int b, int r, int n)
        {
            int count = 0;

            // code here
            for(int i=0; i<n; i++)
            {
                double x =int.Parse(Console.ReadLine());
                double y = int.Parse(Console.ReadLine());
                double x1 = x - a;
                double y1 = y - b;
                if (Math.Sqrt(x1 * x1 + y1 * y1)<=r)
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
            double z = double.MaxValue;
            int count = 0;
            for (int i = 0; i < n; i++)
            {
               
                int xn = int.Parse(Console.ReadLine());
                int yn = int.Parse(Console.ReadLine());

                if(Math.Sqrt(xn*xn+yn*yn) < z)
                {
                    z = Math.Sqrt(xn * xn + yn * yn);
                    index = count;
                }
                count++;
            }
            length = z;
            // end

            return (index, length);
        }
        public int Task3()
        {
            int count = 0;

            // code here
            while (true)
            {
                string input = Console.ReadLine();
                double x;
                double pi = 3.14;
                if (double.TryParse(input, out x))
                {
                }
                else
                {
                    break;
                }
                input = Console.ReadLine();
                double y;
                if (double.TryParse(input, out y))
                { }
                else
                {
                    break;
                }
                if (x>=0 && x<= pi && y >= 0 && y <= Math.Sin(x))
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
                    labs--;
                }
                else
                {
                    score += 4 * mark;
                    cw--;
                }
                // end
            }

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
                    area = (a / 4.0) * Math.Sqrt(4.0 * b * b - (double)a * a);
                    break;

            }
            // end

            return area;
        }
    }
}