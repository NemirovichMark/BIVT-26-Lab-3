namespace Lab3
{
    public class Blue
    {
        public double Task1(int n, int glass, int norma)
        {
            double milk = 0;

            // code here
            double ves;
            while (n != 0)
            {
                ves = double.Parse(Console.ReadLine());
                if (ves < norma)
                {
                    milk =milk+ glass / 1000.0;
                }
                n = n - 1;
            }
            // end

            return milk;
        }
        public (int first, int second, int third, int fourth) Task2(int n)
        {
            int first = 0, second = 0, third = 0, fourth = 0;

            // code here
            while (n != 0)
            {
                double x = double.Parse(Console.ReadLine());
                double y = double.Parse(Console.ReadLine());
                if (x > 0 && y > 0)
                {
                    first++;
                }
                if (x < 0 && y > 0)
                {
                    second++;
                }
                if (x < 0 && y < 0)
                {
                    third++;
                }
                if (x > 0 && y < 0)
                {
                    fourth++;
                }

                n--;
            }
            // end

            return (first, second, third, fourth);
        }
        public int Task3(int n)
        {
            int count = 0 ;

            // code here
            for (int i = 0; i < n; i++)
            {
                int perv = int.Parse(Console.ReadLine());
                int vtor = int.Parse(Console.ReadLine());
                int trit = int.Parse(Console.ReadLine());
                int four = int.Parse(Console.ReadLine());
                if (perv != 2 && perv != 3 && vtor != 2 && vtor != 3 && trit != 2 && trit != 3 && four != 2 && four != 3)
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
            int taskTime = 10;
            // code here
            while (time < 1440)
            {
                if (tasks > 0)
                {
                    time += taskTime;
                    taskTime += 5;
                    tasks--;
                }
                else
                {
                    int seriasTime = int.Parse(Console.ReadLine());
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
            if (number == 2)
            {
                power -= 5;
                agility += 5;
                intellect -= 5;
            }
            if (number == 3)
            {
                power += 10;
                intellect -= 5;
            }
            if (number == 4)
            {
                power -= 10;
                intellect -= 10;
                agility += 15;
            }
            if (number == 5)
            {
                power -= 5;
                intellect += 7;
            }


            if (power < 0)
                power = 0;
            if (agility < 0)
                agility = 0;
            if (intellect < 0)
                intellect = 0;
            // end

            return (power, agility, intellect);
        }
    }
}