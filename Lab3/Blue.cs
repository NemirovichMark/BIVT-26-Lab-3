namespace Lab3
{
    public class Blue
    {
        public double Task1(int n, int glass, int norma)
        {
            double milk = 0;

            // code here
            int count = 0;
            for (int i = 0; i < n; i++)
            {
                double vesu = double.Parse(Console.ReadLine());
                if (vesu < norma)
                {
                    count++;
                }
            }
            milk = Math.Round(count * (glass / 1000.0), 10);
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
                if (x > 0 && y > 0)
                {
                    first++;
                }
                else if (x < 0 && y > 0)
                {
                    second++;
                }
                else if (x < 0 && y < 0)
                {
                    third++;
                }
                else if (x > 0 && y < 0)
                {
                    fourth++;
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
                int o1 = int.Parse(Console.ReadLine());
                int o2 = int.Parse(Console.ReadLine());
                int o3 = int.Parse(Console.ReadLine());
                int o4 = int.Parse(Console.ReadLine());
                if (o1 > 3 && o2 > 3 && o3 > 3 && o4 > 3)
                {
                    count++;
                }
            }
            // end

            return count;
        }
        public (int tasks, int serias) Task4(int time, int tasks)
        {
            int serias = 0;

            // code here
            int seriasTime, taskTime = 10; serias = 0;
            while (time < 24 * 60)
            {
                if (tasks > 0)
                {
                    time += taskTime;
                    taskTime += 5;
                    tasks--;
                }
                else if (tasks <= 0)
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

            // code here
            if (number == 1)
            {
                power += 10;
                intellect -= 5;
            }
            else if (number == 2)
            {
                agility += 5;
                power -= 5;
                intellect -= 5;
            }
            else if (number == 3)
            {
                power += 10;
                intellect -= 5;
            }
            else if (number == 4)
            {
                agility += 15;
                power -= 10;
                intellect -= 10;
            }
            else if (number == 5)
            {
                intellect += 7;
                power -= 5;
            }
            if (power < 0)
            {
                power *= 0;
            }
            if (agility < 0)
            {
                agility *= 0;
            }
            if (intellect < 0)
            {
                intellect *= 0;
            }



            // end

            return (power, agility, intellect);
        }
    }
}
