namespace Lab3
{
    public class Blue
    {
        public double Task1(int n, int glass, int norma)
        {
            double milk = 0;

            // code here

            for (int i = 0; i < n; i = i + 1)
            {
                double weight = double.Parse(Console.ReadLine());

                if (weight < norma)
                {
                    milk = milk + glass;
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

            for (int i = 0; i < n; i = i + 1)
            {
                double x = double.Parse(Console.ReadLine());
                double y = double.Parse(Console.ReadLine());

                if (x > 0 && y > 0)
                {
                    first = first + 1;
                }
                else if (x < 0 && y > 0)
                {
                    second = second + 1;
                }
                else if (x < 0 && y < 0)
                {
                    third = third + 1;
                }
                else if (x > 0 && y < 0)
                {
                    fourth = fourth + 1;
                }
            }

            // end

            return (first, second, third, fourth);
        }
        public int Task3(int n)
        {
            int count = 0;

            // code here

            for (int i = 0; i < n; i = i + 1)
            {
                int a = int.Parse(Console.ReadLine());
                int b = int.Parse(Console.ReadLine());
                int c = int.Parse(Console.ReadLine());
                int d = int.Parse(Console.ReadLine());

                if (a >= 4 && b >= 4 && c >= 4 && d >= 4)
                {
                    count = count + 1;
                }
            }

            // end

            return count;
        }
        public (int tasks, int serias) Task4(int time, int tasks)
        {
            int serias = 0;

            // code here

            int taskTime = 10;

            while (time < 24 * 60)
            {
                if (tasks > 0)
                {
                    time = time + taskTime;
                    taskTime = taskTime + 5;
                    tasks = tasks - 1;
                }
                else
                {
                    int seriasTime = int.Parse(Console.ReadLine());
                    time = time + seriasTime;
                    serias = serias + 1;
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
                case 1:
                    power = power + 10;
                    intellect = intellect - 5;
                    break;

                case 2:
                    agility = agility + 5;
                    power = power - 5;
                    intellect = intellect - 5;
                    break;

                case 3:
                    power = power + 10;
                    intellect = intellect - 5;
                    break;

                case 4:
                    agility = agility + 15;
                    power = power - 10;
                    intellect = intellect - 10;
                    break;

                case 5:
                    intellect = intellect + 7;
                    power = power - 5;
                    break;
            }

            if (power < 0)
            {
                power = 0;
            }

            if (agility < 0)
            {
                agility = 0;
            }

            if (intellect < 0)
            {
                intellect = 0;
            }

            // end

            return (power, agility, intellect);
        }
    }
}