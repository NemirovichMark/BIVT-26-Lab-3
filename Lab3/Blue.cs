namespace Lab3
{
    public class Blue
    {
        public double Task1(int n, int glass, int norma)
        {
            double milk = 0;
            double count = 0;
            // code here
            for (int i = 1; i <= n; i++)
            {
                double.TryParse(Console.ReadLine(), out double r);
                if (r < norma)
                {
                    count++;
                }
                milk = (count * glass) / 1000.0;
            }
            // end

            return milk;
        }
        public (int first, int second, int third, int fourth) Task2(int n)
        {
            int first = 0, second = 0, third = 0, fourth = 0,i = 0;

            // code here
            while (i<n)
            {
                double x = double.Parse(Console.ReadLine());
                double y = double.Parse(Console.ReadLine());

                if (x > 0 && y > 0) first++;
                if (x < 0 && y > 0) second++;
                if (x < 0 && y < 0) third++;
                if (x > 0 && y < 0) fourth++;
                i++;
            }
            // end

            return (first, second, third, fourth);
        }
        public int Task3(int n)
        {
            int count = 0;

            // code here
            for (int i = 1; i <= n; i++)
            {
                bool badmark = false;

                int mark1 = int.Parse(Console.ReadLine());
                if (mark1 == 2  mark1 == 3) badmark = true;

                int mark2 = int.Parse(Console.ReadLine());
                if (mark2 == 2  mark2 == 3) badmark = true;

                int mark3 = int.Parse(Console.ReadLine());
                if (mark3 == 2  mark3 == 3) badmark = true;

                int mark4 = int.Parse(Console.ReadLine());
                if (mark4 == 2  mark4 == 3) badmark = true;

                if (!badmark) count++;
            }
            // end

            return count;
        }
        public (int tasks, int serias) Task4(int time, int tasks)
        {
            // code here
            int seriasTime = 0;
            int taskTime = 10;
            int serias = 0;

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
            switch (number)
            {
                case 1:
                    power += 10;
                    intellect -= 5;
                    break;
                case 2:
                    agility += 5;
                    intellect -= 5;
                    power -= 5;
                    break;
                case 3:
                    power += 10;
                    intellect -= 5;
                    break;
                case 4:
                    agility -= 15;
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
            // end
            return (power, agility, intellect);
        }

    }
}
