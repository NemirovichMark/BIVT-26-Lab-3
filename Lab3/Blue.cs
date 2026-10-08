namespace Lab3
{
    public class Blue
    {
        
        public double Task1(int n, int glass, int norma)
        {
            double milk = 0;
            int su = 0;
            
            // code here
            for (int i = 0; i < n; i++)
            {
                double weight = int.Parse(Console.ReadLine());
                if (weight < norma) su += glass;
            }
            // end
            milk = su / 1000.00;
            return milk;
        }
        public (int first, int second, int third, int fourth) Task2(int n)
        {
            int first = 0, second = 0, third = 0, fourth = 0;

            // code here

            // end

            return (first, second, third, fourth);
        }
        public int Task3(int n)
        {
            int count = 0;

            // code here

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
                    seriasTime = int.Parse(Console.ReadLine()!);
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
                case 1 or 3:
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
            
            if (power < 0) power = 0;
            if (agility < 0) agility = 0;
            if (intellect < 0) intellect= 0;

            
            // end

            return (power, agility, intellect);
        }
    }
}
