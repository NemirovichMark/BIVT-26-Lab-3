using System.Net.Http.Headers;

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

                double dist = Math.Sqrt(x * x + y * y);

                if ((dist > r1) && (dist < r2))
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
            double sum = 0;
            
            for (int i = 0; i < n; i++)
            {
                int first = int.Parse(Console.ReadLine());
                int second = int.Parse(Console.ReadLine());
                int third = int.Parse(Console.ReadLine());
                int fourth = int.Parse(Console.ReadLine());

                sum += first + second + third + fourth;

                if ((first == 2) || (second == 2) || (third == 2) || (fourth == 2))
                {
                    count++;
                }
            }

            if (n > 0)
            {
                average = sum / 4 / n;
            }
            // end

            return (count, average);
        }
        public double Task3(int exams)
        {
            double avgMark = 0;

            // code here
            int theory, practice, mark = 0;
            int n = exams;
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
                if ((score <= 85) && (score > 70))
                {
                    mark = 4;
                }
                if ((score <= 70) && (score > 50))
                {
                    mark = 3;
                }
                if (score <= 50)
                {
                    mark = 2;
                }

                avgMark += (double)mark / (double)n;
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
            while (attempts < limit)
            {
                attempts++;
                string first = Console.ReadLine();
                if (first == "-1") { solution = "Аварийный выход!"; break; }

                string second = Console.ReadLine();
                if (second == "-1") { solution = "Аварийный выход!"; break; }

                string third = Console.ReadLine();
                if (third == "-1") { solution = "Аварийный выход!"; break; }

                int newCode = int.Parse((first + second + third));
                if (newCode == code)
                {
                    solution = "Доступ разрешен!";
                    break;
                }
            }

            if ((attempts == limit) && (solution != "Доступ разрешен!") && (solution != "Аварийный выход!"))
            {
                solution = "Система заблокирована!";
            }
            // end

            return (solution, attempts);
        }
        public double Task5(int a, int n)
        {
            double luck = 0;

            for (int i = 0; i < n; i++)
            {
                switch (a)
                {
                    case 1:
                    case 8:
                    case 15:
                    case 22:
                    case 29:
                        if (luck * 1.5 < 100) luck *= 1.5; else luck = 100;
                        break;
                    case 4:
                    case 11:
                    case 18:
                    case 25:
                        if (luck - 10 > 0) luck -= 10; else luck = 0;
                        break;
                    case 7:
                    case 14:
                    case 21:
                    case 28:
                        if (luck < 50) luck = 55;
                        break;
                    default:
                        if (luck + 5 < 100) luck += 5; else luck = 100;
                        break;
                }
                a++;
                if (a > 30) a = 1;
            }

            return luck;
        }
    }
}
