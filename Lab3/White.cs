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
            for (int i = 1; i <= n; i++)
            {
                Console.Write($"Введите рост ученика {i} :");
                sum += Convert.ToDouble(Console.ReadLine());
            }
            if (n > 0) 
            {
                    averageHeight += sum / n;
            }

            // end

            return averageHeight;
        }
        public double Task2(int n)
        {
            double bestResult = 0;

            // code here
            if (n == 0) return 0;
            bestResult = double.MaxValue;
            for (int i=1;i<=n;i++)
            {
                Console.Write($"Введите время спортсмена {i} (сек):");
                double time = Convert.ToDouble(Console.ReadLine());
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
            for (int i = 1; i <= n; i++)
            {
                Console.Write($"Введите значение {i}:");
                double value = Convert.ToDouble(Console.ReadLine());
                if (value < limit)
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
            Console.Write("Введите amount:");
            amount = Convert.ToInt32(Console.ReadLine());
            while (amount < maxAmount)
            {
                if (hours % 5!=4)
                {
                   amount++; 
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
                case 1 : area = r * r;
                    break;
                case 2 : area = Math.PI * r * r;
                    break;
                case 3 : area = (Math.Sqrt(3)/4*r * r);
                    break;
                default:
                    Console.WriteLine("Неизвестный тип");
                    break;
            }

            // end

            return area;
        }
    }
}
