using System.Security.Cryptography.X509Certificates;

namespace Lab3
{
    public class White
    {
        public double Task1(int n)
        {
            double averageHeight = 0;

            // code here
            if (n <= 0)
            {
                return 0;
            }

            for (int i = 1; i <= n; i++)
            {
                Console.WriteLine("Введите рост ученика:");
                double height = double.Parse(Console.ReadLine());
                averageHeight += height;
            }

            averageHeight /= n;

            // end

            return averageHeight;
        }
        public double Task2(int n)
        {
            double bestResult = 0;

            // code here
            //int n = int.Parse(Console.ReadLine());
            for (int i = 1; i <= n; i++)
            {
                Console.WriteLine($"Введите результат {i}-го спортсмена:");
                double result = double.Parse(Console.ReadLine());

                if (i == 1 || result < bestResult)
                {
                    bestResult = result;
                }
            }

            Console.WriteLine("Время лучшего спортсмена: " + bestResult);

            // end

            return bestResult;
        }
        public int Task3(int n, double limit)
        {
            int count = 0;

            // code here
            for (int i = 1; i <= n; i++)
            {
                Console.WriteLine($"Введите результат {i}-го спортсмена:");
                double result = double.Parse(Console.ReadLine());

                if (result <= limit)
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
            while (amount < maxAmount)
            {
                if (hours % 5 != 4)
                {
                    amount += 1;
                }
                else
                {
                    amount -= 2;
                }
                hours++;
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

                default:
                    Console.WriteLine("Неверное значение type");
                    break; // Обязательно добавьте break в default
            }

            // end

            return area;
        }
    }
}
