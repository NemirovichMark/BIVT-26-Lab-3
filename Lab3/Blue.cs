namespace Lab3
{
    public class Blue
    {
        public double Task1(int n, int glass, int norma)
        {
            double milk = 0;

            // code here
            double v;
            for (int i = 0; i < n; i++)
            {
                double.TryParse(Console.ReadLine(), out v);
                if (v < norma)
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
            for (int i = 0; i < n; i++)
            {
                string[] s = Console.ReadLine().Split();
                double.TryParse(s[0], out double x);
                double.TryParse(s[1], out double y);

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

            // code here

            for (int i = 0; i < n; i++)
            {

                string[] g = Console.ReadLine().Split();
                int gr1 = int.Parse(g[0]);
                int gr2 = int.Parse(g[1]);
                int gr3 = int.Parse(g[2]);
                int gr4 = int.Parse(g[3]);
                if (gr1>= 4 && gr2 >= 4 && gr3 >= 4 && gr4 >= 4)
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
            int seriasTime, taskTime = 10;
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
                    agility += 15;
                    power -= 10;
                    intellect -= 10;
                    break;
                case 5:
                    intellect += 7;
                    power -= 5;
                    break;
            }
            power = Math.Max(power, 0);
            agility = Math.Max(agility, 0);
            intellect = Math.Max(intellect, 0);
            // end

            return (power, agility, intellect);
        }
    }
}
