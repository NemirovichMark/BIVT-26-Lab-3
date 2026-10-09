using System.Reflection;

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
        double minDistance = double.MaxValue;
        for (int i = 1; i <= n; i++)
        {
            string[] parts = Console.ReadLine().Split(' ');
            double x = double.Parse(parts[0]);
            double y = double.Parse(parts[1]);
            double distance = x * x + y * y;
            if (distance < minDistance)
                {
                minDistance = distance;
                index = i;
                }
        }

        if (n > 0)
        {
            double z;
            double squareRoot = minDistance / 2;
            do
            {
                z = squareRoot;
                squareRoot = (z + (minDistance / z)) / 2;
                
            } while ((z - squareRoot) != 0);
            length = squareRoot; 
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
                string[] parts = Console.ReadLine().Split(' ');
                if (parts.Length < 2)
                {
                    break;
                }
                double x = double.Parse(parts[0]);
                double y = double.Parse(parts[1]);
                if (x >= 0 &&  x <= 3.14159265 && y >= 0 && y <= Math.Sin (x))
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
        while ( labs > 0 || cw > 0)
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
                if (a > b)
                    {
                    area = 3.14159265 * (a * a - b * b );
                    }
                else
                {
                    area = 3.14159265 * (b * b - a * a);
                }
            }
            else if (type == 3)
            {
                double number = b * b - (a * a / 4.0);
                double h = number / 2;
                for (int i = 0; i < 100; i++)
                {
                    h = (h + number / h) / 2;
                }

                area = 0.5 * a * h;
            }
            // end

            return area;
        }
    }
}