using System.Security.Cryptography;

namespace Lab3
{
    public class Blue
    {
        public double Task1(int n, int glass, int norma)
        {
            double milk = 0;

            // code here
            int z = 0;
            for (int i = 0; i < n; i++)
            {
                double a = double.Parse(Console.ReadLine());
                if (a < norma)
                    z++;
            }
            milk = (z * glass) / 1000.0;
            // end

            return milk;
        }
        public (int first, int second, int third, int fourth) Task2(int n)
        {
            int first = 0, second = 0, third = 0, fourth = 0;

            // code here
            for (int i = 0; i < n; i++)
            {
                double x = double.Parse(Console.ReadLine());
                double y = double.Parse(Console.ReadLine());
                switch (x,y)
                {
                    case ( > 0, > 0):
                        first++;
                        break;
                    case ( < 0, > 0):
                        second++;
                        break;
                    case ( < 0, < 0):
                        third++;
                        break;
                    case (> 0, < 0): 
                        fourth++;
                        break;
                    default:
                        break;
                }
                
            }
                
            // end

            return (first, second, third, fourth);
        }
        public int Task3(int n)
        {
            int count = 0;

            // code here
            for (int i = 0; i < n; i++)
            {
                int a1 = int.Parse(Console.ReadLine());
                int a2 = int.Parse(Console.ReadLine());
                int a3 = int.Parse(Console.ReadLine());
                int a4 = int.Parse(Console.ReadLine());
                switch (a1,a2,a3,a4)
                {
                    case ( > 3, > 3, > 3, > 3):
                        count++;
                        break;
                    default:
                        break;
                }
            }
            //или так
            //    if (a1 > 3 && a2 > 3 && a3 > 3 && a4 > 3)
            //    count++;
            // end

            return count;
        }
        public (int tasks, int serias) Task4(int time, int tasks)
        {
            int serias = 0;

            // code here
            int tasktime = 10;
            int seriastime = 0;
            while (time < 1440)
            {
                if (tasks > 0)
                {
                    time += tasktime;
                    tasktime += 5;
                    tasks--;
                }
                else
                {
                    int a = int.Parse(Console.ReadLine());
                    time += seriastime;
                    serias++;
                }
            }
            // end

            return (tasks, serias);
        }
        public (int power, int agility, int intellect) Task5(int power, int agility, int intellect, int number)
        {

            // code here
            switch (number)
            {
                case 1 or 3:
                    power += 10;
                    intellect -= 5;
                    if (intellect < 0)
                        intellect = 0;
                    break;
                case 2:
                    agility += 5;
                    power -= 5;
                    intellect -= 5;
                    if (power < 0)
                        power = 0;
                    if (intellect < 0)
                        intellect = 0;
                    break;
                case 4:
                    agility += 15;
                    power -= 10;
                    intellect -= 10;
                    if (power < 0)
                        power = 0;
                    if (intellect < 0)
                        intellect = 0;
                    break;
                case 5:
                    intellect += 7;
                    power -= 5;
                    if (power < 0)
                        power = 0;
                    break;
            }
            // end

            return (power, agility, intellect);
        }
    }
}