namespace Lab3
{
    public class Green
    {
        public double Task1(int a, int b, int r, int n)
        {
            int count = 0;
            for (int i = 0; i < n; i++)
            {
                double.TryParse(Console.ReadLine(), out double x);
                double.TryParse(Console.ReadLine(), out double y);


                if (((x - a) * (x - a)) + (y - b) * (y - b) <= r * 2)
                {

                    count++;
                }

            }

            Console.WriteLine(count);
            return count;
        }
        public (int index, double length) Task2(int n)
        {
            int index = 0;
            double length = 0,s=0;
            if (n <= 0) return (0, 0.0);
            length = double.MaxValue;
            for (int i = 1; i <=n; i++)
            {
                double.TryParse(Console.ReadLine(), out double x);
                double.TryParse(Console.ReadLine(), out double y);

                s = Math.Sqrt(x * x + y * y);
                if (length<s)
                {
                    length = s;
                    index = i;
                }
            }
                return (index, length);
        }
        public int Task3()
        {
            int count = 0;

            while (true)
            { 
                if (!double.TryParse(Console.ReadLine(), out double x))
                {
                    
                    break;
                }

                
                

                if (!double.TryParse(Console.ReadLine(), out double y))
                {
                    
                    break;
                }

                
                if (x >= 0 && x <= Math.PI && y >= 0 && y <= Math.Sin(x))
                {
                    count++;
                }
            }
            Console.WriteLine(count);
            return count;
        }
        public int Task4(int labs, int cw)
        {
            int score = 0;
            int mark = 0;
            while (labs>0 || cw>0) {
            int.TryParse(Console.ReadLine(), out mark);
                if (labs > 0)
                {
                    score += mark;
                    labs--;
                }
                else
                {
                    score += 4 * mark;
                    cw--;
                }
            }

            return score;
        }
        public double Task5(int a, int b, int type)
        {
            double area = 0;
            switch(type){
                case 1: 
                    area=a*b; break;
                case 2:
                    area = Math.Abs(a * a  - b * b )* Math.PI; break;
                case 3:
                    double s = a;
                    area = a * Math.Sqrt(b*b-(s/2)*(s/2)) / 2;break;
            
            
            
            
                default: area=0;break;
            }

            return area;
        }
    }
}
