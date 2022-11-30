namespace ConsoleApplication12
{
    class Program
    {
        static double Function(int a, int i)
        {
            double I = 0.0;
            I = (Math.Pow(i + 1, 1.0 / 2)) / (4 * i - 3) * Math.Pow(a, i);
            return I;
        }
        static void Main(string[] args)
        {
            try
            {
                int a = 0;
                int n = 0;
                do
                {
                    Console.WriteLine("Введите n>0");
                    n = int.Parse(Console.ReadLine());
                } while (n < 0);
                Console.WriteLine("Введите a");
                a = int.Parse(Console.ReadLine());
                double result = 0.0;
                for (int i = 1; i < n; i++)
                {
                    result += Function(a, i);
                }
                Console.WriteLine("{0,3:F3}", result);
                Console.ReadKey();
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
        }
    }
}


