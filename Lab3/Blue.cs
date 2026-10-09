using System.Security.Cryptography.X509Certificates;

namespace Lab3
{
    public class Blue
    {
        public double Task1(int n, int glass, int norma)
        {
            double milk = 0;

            // code here
            for (int i = 0; i < n; i++)
            {
                double weight = double.Parse(Console.ReadLine());
                if (weight < norma)
                {
                    milk += glass;
                }
            }
            milk = milk / 1000;
            // end

            return milk;
        }
        public (int first, int second, int third, int fourth) Task2(int n)
        {
            int first = 0, second = 0, third = 0, fourth = 0;

            // code here
            if (n >= 1)
            {
                for (int i = 0; i < n; i++)
                {
                    double x = double.Parse(Console.ReadLine());
                    double y = double.Parse(Console.ReadLine());
                    if ((x > 0) && (y > 0))
                    {
                        first += 1;
                    }
                    if ((x < 0) && (y > 0))
                    {
                        second += 1;
                    }
                    if ((x < 0) && (y < 0))
                    {
                        third += 1;
                    }
                    if ((x > 0) && (y < 0))
                    {
                        fourth += 1;
                    }

                }
            }

            // end

            return (first, second, third, fourth);
        }
        public int Task3(int n)
        {
            int count = 0;

            // code here
            for (int i = 0; i <= n; i++)
            {
                int mark1 = int.Parse(Console.ReadLine());
                int mark2 = int.Parse(Console.ReadLine());
                int mark3 = int.Parse(Console.ReadLine());
                int mark4 = int.Parse(Console.ReadLine());
                if ((mark1 > 3) && (mark2 > 3) && (mark3 > 3) && (mark4 > 3))
                {
                    count += 1;
                }
            }
            // end

            return count;
        }
        public (int tasks, int serias) Task4(int time, int tasks)
        {
            int serias = 0;
            int seriasTime;
            int taskTime = 10;

            // code here
            while (time < 1440)
            {
                if (tasks < 0)
                {
                    time += taskTime;
                    taskTime += 5;
                    tasks--;
                }
                else
                {
                    seriasTime = int.Parse(Console.ReadLine());
                    time += seriasTime;
                    serias++;
                }
            }
            // end

            return (tasks, serias);
        }
        public (int power, int agility, int intellect) Task5(int power, int agility, int intellect, int number)
        {
           
            switch (number)
            {
                case 1:
                case 3:
                    power += 10;
                    intellect -= 5;
                    break;

                case 2:
                    agility += 5;
                    power -= 5;
                    intellect -= 5;
                    break;

                case 4:
                    agility += 15;
                    power -= 10;
                    intellect -= 10;
                    break;

                case 5:
                    intellect += 7;
                    power -= 5;
                    break;

                default:
                    break;
            }

            
            if (power < 0) power = 0;
            if (agility < 0) agility = 0;
            if (intellect < 0) intellect = 0;

            return (power, agility, intellect);
        }
    }
}
