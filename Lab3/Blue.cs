namespace Lab3
{
    public class Blue
    {
        public double Task1(int n, int glass, int norma)
        {
            double milk = 0;

            // code here
            if (n != 0 && glass != 0 && norma != 0)
            {
                for (int i = 0; i < n; i++)
                {
                    double weight = double.Parse(Console.ReadLine());
                    if (weight < norma)
                    {
                        milk += glass;
                    }
                }
                milk /= 1000;
            }
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

                if (x > 0 && y > 0) first++;
                else if (x < 0 && y > 0) second++;
                else if (x < 0 && y < 0) third++;
                else if (x > 0 && y < 0) fourth++;
            }
            // end

            return (first, second, third, fourth);
        }
        public int Task3(int n)
        {
            int count = 0;

            //code here
            for (int i = 0; i < n; i++)
            {
                int o1 = int.Parse(Console.ReadLine());
                int o2 = int.Parse(Console.ReadLine());
                int o3 = int.Parse(Console.ReadLine());
                int o4 = int.Parse(Console.ReadLine());
                if (o1 != 3 && o2 != 3 && o3 != 3 && o4 != 3)
                    if (o1 != 2 && o2 != 2 && o3 != 2 && o4 != 2)
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
            int seriasTime;
            int taskTime = 10;
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
            switch(number)
            {
                case 1:
                    power += 10;
                    intellect -= 5;
                    if (intellect < 0)
                    {
                        intellect = 0;
                    }
                    break;
                case 2:
                    agility += 5;
                    intellect -= 5;
                    power -= 5;
                    if(power < 0)
                    {
                        power = 0;
                    }
                    if(intellect<0)
                    {
                        intellect = 0;
                    }
                    break;
                case 3:
                    power += 10;
                    intellect -= 5;
                    if(intellect<0)
                    {
                        intellect = 0;
                    }
                    break;
                case 4:
                    agility += 15;
                    power -= 10;
                    intellect -= 10;
                    if (intellect<0)
                    {
                        intellect = 0;
                    }
                    if (power<0)
                    {
                        power = 0;
                    }
                    break;
                case 5:
                    intellect += 7;
                    power -= 5;
                    if(power<0)
                    {
                        power = 0;
                    }
                    break;
            }
            // end

            return (power, agility, intellect);
        }
    }
}
