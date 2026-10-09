using System.Net.Http.Headers;
using System.Runtime.ExceptionServices;
using static System.Math;

namespace Lab3
{
    public class Purple
    {
        public int Task1(int n, int r1, int r2)
        {
            int count = 0;

            // code here
            for (int i = 0; i < n; i++)
            {
                double x = double.Parse(Console.ReadLine());
                double y = double.Parse(Console.ReadLine());

                if ((x*x + y*y >= r1*r1) && (x*x + y*y <= r2*r2))
                {
                    count++;
                }
            }
            // end

            return count;
        }
        public (int count, double average) Task2(int n)
        {
            int count = 0;
            double average = 0;

            // code here
            for (int i = 0; i < n; i++)
            {
                int m1 = int.Parse(Console.ReadLine());
                int m2 = int.Parse(Console.ReadLine());
                int m3 = int.Parse(Console.ReadLine());
                int m4 = int.Parse(Console.ReadLine());

                if (m1 == 2 || m2 == 2 || m3 == 2 || m4 == 2) count++;

                average += m1 + m2 + m3 + m4;
            }
            average /= 4 * n; 
            // end

            return (count, average);
        }
        public double Task3(int exams)
        {
            double avgMark = 0;

            // code here
            int mark, n = exams;
            double score;
            while (exams > 0)
            {
                int theory = int.Parse(Console.ReadLine());
                int practice = int.Parse(Console.ReadLine());
                score = 0.4 * theory + 0.6 * practice;

                if (score > 85) mark = 5;
                else if (score > 70) mark = 4;
                else if (score > 50) mark = 3;
                else mark = 2;

                avgMark += (double)mark / n;
                exams--;
            }
            // end

            return avgMark;
        }
        public (string solution, int attempts) Task4(int code, int limit)
        {
            string solution = "Код не подобран";
            int attempts = 0;

            // code here
                while(limit > 0)
            {
                limit--;
                attempts++;

                int c1 = int.Parse(Console.ReadLine());
                int c2 = int.Parse(Console.ReadLine());
                int c3 = int.Parse(Console.ReadLine());

                if (c1 == -1 || c2 == -1 || c3 == -1)
                {
                    solution = "Аварийный выход!";
                    break;
                }

                int r = 100 * c1 + 10 * c2 + c3;
                if (r == code)
                {
                    solution = "Доступ разрешен!";
                    break;
                }

                else if(limit == 0)
                {
                    solution = "Система заблокирована!";
                    break;
                }
            }
            // end

            return (solution, attempts);
        }
        public double Task5(int a, int n)
        {
            double luck = 0;

            // code here
            for (int i = a; i < a + n; i++)
            {
                switch (i)
                {
                    case 1 or 8 or 15 or 22 or 29:
                        luck *= 1.5;
                        if (luck > 100) luck = 100;
                        break;
                    case 4 or 11 or 18 or 25:
                        luck -= 10;
                        if (luck < 0) luck = 0;
                        break;
                    case 7 or 14 or 21 or 28:
                        if (luck < 50) luck = 55;   
                        break;
                    default:
                        luck += 5;
                        if (luck > 100) luck = 100; 
                            break;
                }
            }
            // end

            return luck;
        }
    }
}
