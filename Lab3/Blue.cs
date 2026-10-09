namespace Lab3
{
    public class Blue
    {
        public double Task1(int n, int glass, int norma)
        {
            double milk = 0;

            // code here
            for (int i = 0; i < n; ++i) {
                double weight = double.Parse(Console.ReadLine());
                if (weight < norma)
                    milk += glass / 1000.0;
            }
            milk = Math.Round(milk, 4);
            // end

            return milk;
        }
        public (int first, int second, int third, int fourth) Task2(int n)
        {
            int first = 0, second = 0, third = 0, fourth = 0;

            // code here
            for (int i = 0; i < n; ++i) {
                double x = double.Parse(Console.ReadLine());
                double y = double.Parse(Console.ReadLine());
                if (x > 0 && y > 0)
                    first += 1;
                if (x < 0 && y > 0)
                    second += 1;
                if (x < 0 && y < 0)
                    third += 1;
                if (x > 0 && y < 0)
                    fourth += 1;
            }
            // end

            return (first, second, third, fourth);
        }
        public int Task3(int n)
        {
            int count = 0;

            // code here
            for (int i = 0; i < n; ++i) {
                int grade1 = int.Parse(Console.ReadLine());
                int grade2 = int.Parse(Console.ReadLine());
                int grade3 = int.Parse(Console.ReadLine());
                int grade4 = int.Parse(Console.ReadLine());
                if (grade1 == 2 || grade2 == 2 || grade3 == 2 || grade4 == 2 || grade1 == 3 || grade2 == 3 || grade3 == 3 || grade4 == 3)
                    continue;
                else
                    count += 1;
            }
            // end

            return count;
        }
        public (int tasks, int serias) Task4(int time, int tasks)
        {
            int serias = 0;

            // code here
            int seriasTime, taskTime = 10;
            while (time < 24 * 60) {
                if (tasks > 0)
                {
                    time += taskTime;
                    taskTime += 5;
                    tasks--;
                }
                else {
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

            // end

            return (power, agility, intellect);
        }
    }
}
