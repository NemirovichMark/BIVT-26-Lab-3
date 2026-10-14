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

                if (((x - a) * (x - a) + (y - b) * (y - b)) <= (double)r * r)
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
            double min = 100000000;
            for (int i = 0; i < n; i++)
            {
                double x = double.Parse(Console.ReadLine());
                double y = double.Parse(Console.ReadLine());
                
                double d = Math.Sqrt(x*x + y*y);
                if (d < min)
                {
                    min = d;
                    index = n;
                    length = min;

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
                string sx = Console.ReadLine();
                string sy = Console.ReadLine();

                double x, y;
                if (!double.TryParse(sx, out x) || !double.TryParse(sy, out y))
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
            }
            return score;
            // end

            
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
                    if (a > b)
                    {
                        area = Math.PI*a*a - Math.PI*b* b;
                        
                    }
                    else
                    {
                        area = Math.PI*b*b - Math.PI*a*a;
                        
                    }

                    break;
                case 3:
                    
                    area = a * Math.Sqrt(b * b - a * a / 4.0) / 2;
                    break;
            }
            // end

            return area;
        }
    }
}