namespace Lab3
{
    public class Blue
    {
        public double Task1(int n, int glass, int norma)
        {
            double milk = 0;

            // code here
            for (var i = 0; i < n; i++)
            {
                var inpWeight = Console.ReadLine();
                var weight = 0.0;
                if (inpWeight != null)
                {
                    weight = double.Parse(inpWeight);
                }
                if (weight < norma)
                {
                    milk += glass;
                }
            }
            milk /= 1000.0;
            // end

            return milk;
        }
        public (int first, int second, int third, int fourth) Task2(int n)
        {
            int first = 0, second = 0, third = 0, fourth = 0;

            // code here
            for (var i = 0; i < n; i++)
            {
                var zx = Console.ReadLine();
                var zy = Console.ReadLine();
                var x = 0.0;
                var y = 0.0;
                if (zx != null && zy != null)
                    x = double.Parse(zx);
                y = double.Parse(zy);
                if (x > 0 && y > 0)
                {
                    first++;
                }
                else if (x < 0 && y > 0)
                {
                    second++;
                }
                else if (x > 0 && y < 0)
                {
                    fourth++;
                }
                else if (x < 0 && y < 0)
                {
                    third++;
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
                int countm = 0;
                for (int i1 = 0; i1 < 4; i1++)
                {
                    var z = Console.ReadLine();
                    int mark = 0;

                    if (z != null)
                    {
                        mark = int.Parse(z);
                    }

                    if (mark > 3)
                    {
                        countm++;
                    }
                }

                if (countm == 4)
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
            int tasksTime = 10;
            for (;time < 1440;)
            {
                if (tasks > 0)
                {
                    time += tasksTime;
                    tasksTime += 5;
                    tasks--;
                }
                else
                {
                    var value = Console.ReadLine();
                    var seriasTime = 0;
                    if (value != null)
                    {
                        seriasTime = int.Parse(value);
                    }
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
            switch (number)
            {
                case 1:
                    power += 10;
                    intellect -= 5;
                    break;
                case 3:
                    power += 10;
                    intellect -= 5;
                    break;
                case 2:
                    agility += 5;
                    intellect -= 5;
                    power -= 5;
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
