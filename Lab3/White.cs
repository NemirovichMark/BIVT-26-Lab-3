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

            for (int i = 0; i < n; i++)
            {
                double height = double.Parse(Console.ReadLine());
                sum += height;
            }

            averageHeight = sum / n;
            // end

            return averageHeight;
        }
        public double Task2(int n)
        {
            double bestResult = 0;

            // code here
   bestResult = double.MaxValue;

for (int i = 0; i < n; i++)
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
  for (int i = 0; i < n; i++)
{
    double time = double.Parse(Console.ReadLine());

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

            // end

            return hours;
        }
        public double Task5(int r, int type)
        {
            double area = 0;

            // code here

            // end

            return area;
        }
    }
}
