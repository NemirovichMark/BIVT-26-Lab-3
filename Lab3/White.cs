using System.Security.Cryptography.X509Certificates;

namespace Lab3
{
    public class White
    {
        public double Task1(int n)
        {
            double averageHeight = 0;

            // code here
            double sum = 0;
            for(int i = 1; i <= n; i++)
            {
                double s = double.Parse(Console.ReadLine());
                sum += s;
            }
            averageHeight = sum / n;
            // end

            return averageHeight;
        }
        public double Task2(int n)
        {
            double bestResult = 0;

            // code here
            for (int i = 1; i <= n; i++)
            {
                double time = double.Parse(Console.ReadLine());
                if (time < bestResult)
                {
                    bestResult = time;
                }
            }
            // end

            return bestResult;
        }
        public int Task3(int n, double limit)
        {
            int count = 0;

            // code here
            for( int i = 1; i <= n; i++)
            {
                double time= double.Parse(Console.ReadLine());
                if (time <= limit)
                {
                    count++;
                }
            }
            // end

            return count;
        }
        public int Task4(int maxAmount)
        {
            int hours = 0;

            // code here
            int amount = 0;
            amount = int.Parse(Console.ReadLine());
            if ( amount < maxAmount)
            {
                if (hours % 5 != 4)
                {
                    amount += 1;
                    hours++;
                }
                else
                {
                    amount -= 2;
                    hours++;
                }
            }
            // end

            return hours;
        }
        public double Task5(int r, int type)
        {
            double area = 0;

            // code here
            switch (type)
            {
                case 1:
                    area = r * r;
                    break;

                case 2:
                    area = Math.PI * r * r;
                    break;

                case 3:
                    area = Math.Sqrt(3) * r * r / 4;
                    break;
            }
            // end

            return area;
        }
    }
}
