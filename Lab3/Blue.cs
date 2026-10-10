namespace Lab3
{
    public class Blue
    {
        public double Task1(int n, int glass, int norma)
        {
            double milk = 0;
            for (int i = 0; i < n; i++)
            {
                double weight = double.Parse(Console.ReadLine()!);
                if (weight < norma) milk += glass / 1000.0;
            }
            return milk;
        }

        public (int first, int second, int third, int fourth) Task2(int n)
        {
            int first = 0, second = 0, third = 0, fourth = 0;
            for (int i = 0; i < n; i++)
            {
                double x = double.Parse(Console.ReadLine()!);
                double y = double.Parse(Console.ReadLine()!);
                if (x > 0 && y > 0) first++;
                else if (x < 0 && y > 0) second++;
                else if (x < 0 && y < 0) third++;
                else if (x > 0 && y < 0) fourth++;
            }
            return (first, second, third, fourth);
        }

        public int Task3(int n)
        {
            int count = 0;
            for (int i = 0; i < n; i++)
            {
                int m1 = int.Parse(Console.ReadLine()!);
                int m2 = int.Parse(Console.ReadLine()!);
                int m3 = int.Parse(Console.ReadLine()!);
                int m4 = int.Parse(Console.ReadLine()!);
                if (m1 != 2 && m1 != 3 && m2 != 2 && m2 != 3 &&
                    m3 != 2 && m3 != 3 && m4 != 2 && m4 != 3)
                    count++;
            }
            return count;
        }

        public (int tasks, int serias) Task4(int time, int tasks)
        {
            int serias = 0;
            int taskTime = 10;
            while (time < 24 * 60)
            {
                if (tasks > 0)
                {
                    time += taskTime;
                    taskTime += 5;
                    tasks--;
                }
                else
                {
                    int seriasTime = int.Parse(Console.ReadLine()!);
                    time += seriasTime;
                    serias++;   
                }
            }
            return (tasks, serias);
        }
        

        public (int power, int agility, int intellect) Task5(int power, int agility, int intellect, int number)
        {
            switch (number)
            {
                case 1:
                    power += 10;
                    intellect -= 5;
                    break;
                case 2:
                    agility += 5;
                    power -= 5;
                    intellect -= 5;
                    break;
                case 3:
                    power += 10;
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
            }
            power = Math.Max(0, power);
            agility = Math.Max(0, agility);
            intellect = Math.Max(0, intellect);
            return (power, agility, intellect);
        }
    }
}
