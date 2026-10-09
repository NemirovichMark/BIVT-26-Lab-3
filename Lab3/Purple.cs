using System.Net.Http.Headers;

namespace Lab3
{
    public class Purple
    {
        public int Task1(int n, int r1, int r2)
        {
            int count = 0;

            for (int i = 0; i < n; i++)
            {
                double x = double.Parse(Console.ReadLine());
                double y = double.Parse(Console.ReadLine());
                double dist = Math.Sqrt(x * x + y * y); 
                if (r1 <= dist && dist <= r2)
                {
                    count ++;
                }
            }

            return count;
        }
        public (int count, double average) Task2(int n)
        {
            int count = 0;
            double average = 0;

            for (int i = 0; i < n; i++)
            {
                int a = int.Parse(Console.ReadLine());
                int b = int.Parse(Console.ReadLine());
                int c = int.Parse(Console.ReadLine());
                int d = int.Parse(Console.ReadLine());
                if (a == 2 || b == 2 || c == 2 || d == 2)
                {
                    count++;
                }
                average += a+b+c+d;
            }

            average = average / (4*n);

            return (count, average);
        }
        public double Task3(int exams)
        {
            int theory = exams;
            int practice = exams;
            int mark = exams;
            int n = exams;
            double avgMark = 0;
            double score = 0;
            while (exams > 0)
            {
                theory = int.Parse(Console.ReadLine());
                practice = int.Parse(Console.ReadLine());
                score = 0.4 * theory + 0.6 * practice;
                if (score > 85)
                {
                    mark = 5;
                }
                else if (score > 70)
                {
                    mark = 4;
                }
                else if (score > 50)
                {
                    mark = 3;
                }
                else
                {
                    mark = 2;
                }
                avgMark += (double)mark / n;
                exams--;
            }
            

            return avgMark;
        }
        public (string solution, int attempts) Task4(int code, int limit)
        {
            string solution = "Система заблокирована!";
            int attempts = 0;


            while (attempts < limit)
            {
                attempts++;
                int a = int.Parse(Console.ReadLine());
                int b = int.Parse(Console.ReadLine());
                int c = int.Parse(Console.ReadLine());

                if (a == -1 || b == -1 || c == -1)
                {
                    solution = "Аварийный выход!";
                    return (solution, attempts);
                }

                if (a * 100 + b * 10 + c == code)
                {
                    solution = "Доступ разрешен!";
                    return (solution, attempts);

                }
            }

            return (solution, attempts);
        }
        public double Task5(int a, int n)
        {
            double luck = 0;
            for (int i = 0; i < n; i++)
            {
                int day = (a + i - 1) % 29 + 1;

                switch (day)
                {
                    case 1:
                    case 8:
                    case 15:
                    case 22:
                    case 29:
                        luck *= 1.5;
                        if (luck > 100) luck = 100;
                        break;

                    case 4:
                    case 11:
                    case 18:
                    case 25:
                        luck -= 10;
                        if (luck < 0) luck = 0;
                        break;

                    case 7:
                    case 14:
                    case 21:
                    case 28:
                        if (luck < 50) luck = 55;
                        break;

                    default:
                        luck += 5;
                        if (luck > 100) luck = 100;
                        break;
                }
            }
            
            return luck;
        }
    }
}
