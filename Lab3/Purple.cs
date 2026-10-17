using System.Linq.Expressions;
using System.Net.Http.Headers;
using System.Runtime;

namespace Lab3
{
    public class Purple
    {
        public int Task1(int n, int r1, int r2)
        {
            int count = 0;
            double dst = 0;
            // code here
            while (n>0) {
                Console.WriteLine("Введите X, Y");
                double x = double.Parse(Console.ReadLine());
                double y = double.Parse(Console.ReadLine());
                dst = Math.Sqrt(x * x + y * y);
                if(dst> r1 && dst < r2)
                {
                    count++;
                }
                n--;
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
                int f = 0;

                int j1 = int.Parse(Console.ReadLine());
                int j2 = int.Parse(Console.ReadLine());
                int j3 = int.Parse(Console.ReadLine());
                int j4 = int.Parse(Console.ReadLine());
                if(j1==2 || j2==2 || j3==2 || j4 == 2)
                {
                    f = 1;
                }
                average += j1 + j2 + j3 + j4;
                count+=f;
            }
            if (n != 0)
            {
                average /= (n*4);
            }
            Console.WriteLine($"c {count} a {average}");
            // end

            return (count, average);
        }
        public double Task3(int exams)
        {
            double avgMark = 0;

            // code here
            int th, pr, mk, n = exams;
            double sc;
            while (exams>0)
            {
                th = int.Parse(Console.ReadLine());
                pr = int.Parse(Console.ReadLine());
                sc = 0.4 * th + 0.6 * pr;
                switch (sc)
                {
                    case > 85:
                        mk = 5;
                        break;
                    case > 70:
                        mk = 4;
                        break;
                    case > 50:
                        mk = 3;
                        break;
                    default:
                        mk = 2;
                        break;
                }
                avgMark += mk / (double)n;
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
            int d1 = code / 100;
            int d2 = (code / 10) % 10;
            int d3 = code % 10;
            int f = 0;

            while (attempts < limit)
            {
                attempts++;

                int n1 = int.Parse(Console.ReadLine());
                if (n1 == -1)
                {
                    f = 2;
                    break;
                }
                int n2 = int.Parse(Console.ReadLine());
                if (n2 == -1)
                {
                    f = 2;
                    break;
                }
                int n3 = int.Parse(Console.ReadLine());
                if (n3 == -1)
                {
                    f = 2;
                    break;
                }
                if (n1==d1 && n2==d2 && n3 == d3)
                {
                    f = 1;
                    break;
                }
            }
            switch (f)
            {
                case 0:
                    solution = "Система заблокирована!";
                    break;
                case 1:
                    solution = "Доступ разрешен!";
                    break;
                case 2:
                    solution = "Аварийный выход!";
                    break;

            }
            Console.WriteLine("{0} {1}", solution, attempts);
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
                    case 1:
                    case 8:
                    case 15:
                    case 22:
                    case 29:
                        if (1.5 * luck >= 100) luck = 100;
                        else luck *= 1.5;
                        break;
                    case 4:
                    case 11:
                    case 18:
                    case 25:
                        if (luck <= 10) luck = 0;
                        else luck -= 10;
                        break;
                    case 7:
                    case 14:
                    case 21:
                    case 28:
                        if (luck < 50) luck = 55;
                        break;
                    default:
                        if (luck + 5 > 100) luck = 100;
                        else luck += 5;
                        break;
                }
            }
            // end

            return luck;
        }
    }
}