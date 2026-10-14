namespace Lab3
{
    public class Blue
    {
        public double Task1(int n, int glass, int norma)
        {
            double milk = 0;

            // code here
            for(int i = 0; i < n; i++)
            {
                Console.WriteLine("вес ученика: ");
                bool success = double.TryParse(Console.ReadLine(), out double weight);
                if (success)
                {
                    if (weight < norma)
                    {
                        milk+=glass/1000;
                    }
                }
            }
            // end

            return Math.Round(milk, 4);
        }
        public (int first, int second, int third, int fourth) Task2(int n)
        {
            int first = 0, second = 0, third = 0, fourth = 0;

            // code here
            for(int i = 0; i < n; i++)
            {
                Console.WriteLine("напишите координату x: ");
                int.TryParse(Console.ReadLine(), out int x);
                Console.WriteLine("напишите координату y: ");
                int.TryParse(Console.ReadLine(), out int y);

                if (x > 0 && y > 0)
                {
                    first++;
                }
                else if (x < 0 && y > 0)
                {
                    second++;
                }
                else if (x < 0 && y < 0)
                {
                    third++;
                }
                else if (x > 0 && y < 0)
                {
                    fourth++;
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
                bool has2or3 = false;
                Console.Write("первая оценка");
                int grade = int.Parse(Console.ReadLine());
                if (grade == 2 || grade == 3)
                {
                    has2or3 = true;
                }
                Console.Write("вторая оценка");
                int grade2 = int.Parse(Console.ReadLine());
                if (grade2 == 2 || grade2 == 3)
                {
                    has2or3 = true;
                }
                Console.Write("третья оценка");
                int grade3 = int.Parse(Console.ReadLine());
                if (grade3 == 2 || grade3 == 3)
                {
                    has2or3 = true;
                }
                Console.Write("четвёртая оценка");
                int grade4 = int.Parse(Console.ReadLine());
                if (grade4 == 2 || grade4 == 3)
                {
                    has2or3 = true;
                }
                if (!has2or3)
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
            int seriasTime = 10, taskTime = 10;
            while(time < 60 * 24)
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
                    intellect = intellect-5>= 0 ? intellect - 5 : 0;
                    break;

                case 2:
                    agility += 5;
                    intellect = intellect - 5 >= 0 ? intellect - 5 : 0;
                    power = power - 5 >= 0 ? power - 5 : 0;
                    break;

                case 3:
                    power += 10;
                    intellect = intellect - 5 >= 0 ? intellect - 5 : 0;
                    break;

                case 4:
                   agility += 15;
                   power = power - 10 >= 0 ? power - 10 : 0;
                   intellect = intellect - 10 >= 0 ? intellect - 10 : 0;
                    break;

                case 5:
                   intellect += 7;
                   power = power - 5 >= 0 ? power - 5 : 0;
                    break;

                default:
                    Console.WriteLine("нет такой статуи!");
                    break;
            }
            // end

            return (power, agility, intellect);
        }
    }
}
