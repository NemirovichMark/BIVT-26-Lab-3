namespace Lab3
{
    public class Green
    {
        public double Task1(int a, int b, int r, int n)
        {
            int count = 0;
            for (int i = 0; i < n; i++)
            {
                double x = double.Parse(Console.ReadLine()); // вот эту фигню надо именно так писать
                double y = double.Parse(Console.ReadLine()); // Console.ReadLine не то(((
                double dist = Math.Sqrt((x - a) * (x - a) + (y - b) * (y - b));
                if ( dist <= r)
                {
                    count++;
                }
    
            }
                
            return count;
        }
        public (int index, double length) Task2(int n)
        {
            int index = 0;
            double length = 0;
            for (int i = 0; i < n; i++)
            {
                double x = double.Parse(Console.ReadLine());
                double y = double.Parse(Console.ReadLine());
                double result = Math.Sqrt(x * x + y * y)
                if (result < length || length == 0)
                {
                    index = i;
                    length = result;
                }
            }
            return (index, length);
        }
        public int Task3()
        {
            int count = 0;
            while (true)
            {
                string strX = Console.ReadLine();
                string strY = Console.ReadLine();

                double x;
                double y;

                bool isXnum = double.TryParse(strX; out x);
                bool isYnum = double.TryParse(strY; out y);

                if (!isXnum || !isYnum)
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
                string strMark = Console.ReadLine();
                int mark;
                int.TryParse(strMark, out mark);

                if (labs > 0)
                {
                    score += mark;
                    labs --;
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
                    area = Math.Abs(Math.PI * a * a - Math.PI * b * b);
                    break;
                case 3:
                    area = 0.5 * a * Math.Sqrt(b * b - (a / 2.0) * (a / 2.0));
                    break;
            }
            return area;
        }
    }
}
