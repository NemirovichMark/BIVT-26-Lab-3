namespace Lab3
{
    public class Green
    {
        public double Task1(int a, int b, int r, int n)
        {
            int count = 0;
            // code here
            for (int i = 0; i <= n;i++)
            {
                double x = double.Parse(Console.Readline());
                double y = double.Parse(Console.Readline());
                if ((x - a) * (x - a) + (y - b) * (y - b) <= r * r)
                {
                    count++;
                }
            }
            // end
            return count;
        }
        public (int index, double length) Task2(int n)
        {
            int index = 0;
            double length = 0;

            // code here

            // end

            return (index, length);
        }
        public int Task3()
        {
            int count = 0;

            // code here

            // end

            return count;
        }
        public int Task4(int labs, int cw)
        {
            int score = 0;

            // code here

            // end

            return score;
        }
        public double Task5(int a, int b, int type)
        {
            double area = 0;

            // code here

            // end

            return area;
        }
    }
}
