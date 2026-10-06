using System.Linq.Expressions;
using System.Net.Http.Headers;

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
                for (int j = 0; j < 4; j++) {
                    //Console.WriteLine(i);
                    int grade = int.Parse(Console.ReadLine());
                    average += grade;
                    if (grade == 2)
                    {
                        f = 1;
                    }
                }
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
            while (attempts < limit)
            {
                attempts++;
                int f = 0;
                for (double i = 100; i >=1; i/=10)
                {
                    int n = int.Parse(Console.ReadLine());
                    if (n == -1)
                    {
                        f = 2;
                        break;
                    }
                    else if (n != (int)(code%(10*i) / (int)i)){
                        f = 1;
                    }
                }
                if(f == 2)
                {
                    solution = "Аварийный выход!";
                    break;
                }else if (f == 0)
                {
                    solution = "Доступ разрешен!";
                    break;
                }else if (attempts == limit)
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