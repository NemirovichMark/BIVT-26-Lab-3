using System;

namespace Lab3
{
    public class White
    {
        public double Task1(int n)
        {
            double sum = 0;

            for (int i = 0; i < n; i++)
            {
                double height = Convert.ToDouble(Console.ReadLine());
                sum += height;
            }

            return n > 0 ? sum / n : 0;
        }

        public double Task2(int n)
        {
            double best = double.MaxValue;

            for (int i = 0; i < n; i++)
            {
                double time = Convert.ToDouble(Console.ReadLine());

                if (time < best)
                    best = time;
            }

            return n > 0 ? best : 0;
        }

        public int Task3(int n, double limit)
        {
            int count = 0;

            for (int i = 0; i < n; i++)
            {
                double time = Convert.ToDouble(Console.ReadLine());

                if (time <= limit)
                    count++;
            }

            return count;
        }

        public int Task4(int maxAmount)
        {
            int hours = 0;
            int amount = Convert.ToInt32(Console.ReadLine());

            while (amount < maxAmount)
            {
                if (hours % 5 != 4)
                    amount += 1;
                else
                    amount -= 2;

                hours++;
            }

            return hours;
        }
        //rebuild
        public double Task5(int r, int type)
        {
            switch (type)
            {
                case 1:
                    return r * r;
                case 2:
                    return Math.PI * r * r;
                case 3:
                    return Math.Sqrt(3) * r * r / 4.0;
                default:
                    return 0;
            }
        }
    }
}
