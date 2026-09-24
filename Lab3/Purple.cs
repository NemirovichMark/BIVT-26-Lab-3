using Lab3;
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
                int x = Convert.ToInt32(Console.ReadLine());
                int y = Convert.ToInt32(Console.ReadLine());
                double dist = Math.Sqrt(Math.Pow(x, 2) + Math.Pow(y, 2));
                if (r1 <= dist && dist <= r2)
                {
                    count++;
                }
            }
            return count;
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
                for (int k = 0; k < 4; k++)
                {
                    int mark = Convert.ToInt32(Console.ReadLine());
                    average += mark;
                    if (mark == 2)
                    {
                        count++;
                    }
                }
            }
            average /= n;
            // end

            return (count, average);
        }
        public double Task3(int exams)
        {
            double score, avgMark = 0;

            // code here
            int theory, practice, mark, n = exams;
            while (exams > 0)
            {
                theory = Convert.ToInt32(Console.ReadLine());
                practice = Convert.ToInt32(Console.ReadLine());
                score = 0.4 * theory + 0.6 * practice;
                if (score > 85)
                {
                    mark = 5;
                } else if (score > 70)
                {
                    mark = 4;
                } else if (score > 50)
                {
                    mark = 3;
                } else
                {
                    mark = 2;
                }
                avgMark += mark / n;
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
            do
            {
                string fullCode = "";
                for (int i = 0; i < 3; i++)
                {
                    Console.WriteLine("Введите число:");
                    string givenCode = Console.ReadLine();
                    fullCode += givenCode;

                    if (givenCode == "-1")
                    {
                        solution = "Аварийный выход!";
                        break;
                    }
                }
                attempts++;
                if (solution == "Аварийный выход!")
                {
                    break;
                }
                if (Convert.ToInt32(fullCode) == code)
                {
                    solution = "Доступ разрешён!";
                    break;
                }
                if (attempts == limit)
                {
                    solution = "Система заблокирована!";
                    break;
                }
            } while (attempts < limit || solution != "Аварийный выход!");
            // end

            return (solution, attempts);
        }
        public double Task5(int a, int n)
        {
            double luck = 0;
            int b = a;

            // code here
            for (; a < b+n; a++)
            {
                switch (a)
                {
                    case 1:
                    case 8:
                    case 15:
                    case 22:
                    case 29:
                        luck *= 1.5;
                        if (luck > 100)
                        {
                            luck = 100;
                        }
                        break;

                    case 4:
                    case 11:
                    case 18:
                    case 25:
                        if (luck - 10 >= 0)
                        {
                            luck -= 10;
                        }
                        break;

                    case 7:
                    case 14:
                    case 21:
                    case 28:
                        if (luck < 50)
                        {
                            luck = 55;
                        }
                        break;

                    default:
                        if (luck + 5 <= 100)
                        {
                            luck += 5;
                        }
                        break;
                }
            }
            // end

            return luck;
        }
    };
}

