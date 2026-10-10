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
                double weight = double.Parse(Console.ReadLine());
                if (weight < norma) su += glass;
            }
            // end
            milk = su / 1000.00;
            return milk; // test ok 2026-10-08 17-10
        }
        public (int first, int second, int third, int fourth) Task2(int n)
        {
            int first = 0, second = 0, third = 0, fourth = 0;

            // code here
            for (int i = 0; i < n; i++)
            {
                double xcor = double.Parse(Console.ReadLine());
                double ycor = double.Parse(Console.ReadLine());

                switch (xcor, ycor)
                {
                    case ( > 0, > 0):
                        first++;
                        break;
                    case ( < 0, > 0):
                        second++;
                        break;
                    case ( < 0, < 0):
                        third++;
                        break;
                    case ( > 0, < 0):
                        fourth++;
                        break;
                }
            }
            // end

            return (first, second, third, fourth);
        }
        public int Task3(int n)
        {
            int count = 0;

            // code here
            bool good = true;
            for (int i = 0; i < 4 * n; i++)
            {
                int mark = int.Parse(Console.ReadLine()!);
                if (mark == 2 || mark == 3) good = false;

                if (i % 4 == 3)      
                {
                    if (good) count++;
                    good = true;       
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
                    seriasTime = int.Parse(Console.ReadLine()!);
                    time += seriasTime;
                    serias++;
                }
            }
            // end

            return (tasks, serias); // test ok 2026-10-06 14-42
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
