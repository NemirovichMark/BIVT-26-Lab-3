using System.Globalization;

namespace Lab3
{
    public class Green
    {
        public double Task1(int a, int b, int r, int n)
        {
            double count = 0;
            for (int i = 0; i < n; i++)
            {

                double x = double.Parse(Console.ReadLine());
                double y = double.Parse(Console.ReadLine());
                double dx = a - x;
                double dy = b - y;
                if ((dx*dx+dy*dy) <= r*r)
                {
                    count = count + 1;
                }
            }
            return count;
        }
        public (int index, double length) Task2(int n)
        {
            int index = 0;
            double length = 0;
            double rast = 0;
            double sr = 1111111111110;
            for (int i = 1; i <= n; i++)
            {
                string yy = Console.ReadLine();
                double y = double.Parse(yy);
                string xx = Console.ReadLine();
                double x = double.Parse(xx);
                rast = Math.Sqrt(((0 - x) * (0 - x)) + ((0 - y) * (0 - y)));
                if (rast < sr)
                {
                    sr = rast;
                    index = i;
                    length = rast;
                }
            }
            return (index, length);
        }
        public int Task3()
        {
            int count = 0;
            int p = 1;
            while (p==1)
            {
                string x= Console.ReadLine();
                string y = Console.ReadLine();
                if ((double.TryParse(x, out double number)) && (double.TryParse(y, out number)))
                {
                    double xx = double.Parse(x);
                    double yy= double.Parse(y);
                    if (xx>=0 && yy<=Math.Sin(xx) && xx<=Math.PI && yy>=0)
                    {
                        count++;
                    }
                }
                else
                {
                    p = 0;
                    break;
                }
            }
            return count;
        }
        public int Task4(int labs, int cw)
        {
            int score = 0;
            while (labs>0 || cw>0)
            {
                int mark = int.Parse(Console.ReadLine());
                if (labs>0)
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
                    int rb = Math.Max(a, b);
                    int rm = Math.Min(a, b);
                    double crb = Math.PI * (rb * rb);
                    double crm = Math.PI * (rm * rm);
                    area = crb - crm;
                    break;
                case 3:
                    double pp = (a + b + b) / 2.0;
                    area = Math.Sqrt(pp * (pp - a) * (pp - b) * (pp - b));
                    break;
                default:
                    break;
            }
            return area;
        }
    }
}
