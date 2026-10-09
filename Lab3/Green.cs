namespace Lab3
{
    public class Green
    {
        public double Task1(int a, int b, int r, int n)
        {
            int count = 0;

            // code here

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
            switch(type)
            {
                case 1:
                    area = a * b; break;
                case 2:
                    area = Math.PI * Math.Abs(a * a - b * b); break;
                case 3:
                    double h = Math.Sqrt((b * b - (a / 2.0) * (a / 2.0)));
                    area = (h * a) / 2; break;
            }

            // end

            return area;
        }
    }
}
