using System;
namespace ngay3
{
    class Program
    {
        static void Main(string[] args)
        {
            string s1 = Console.ReadLine();
            var s2 = s1.Split(' ');
            double x = Convert.ToDouble(s2[0]);
            int n = Convert.ToInt32(s2[1]);
            double s = 0;
            double bieuthuc = 1;
            for (int i = 1; i <= n; i++)
            {
                bieuthuc = bieuthuc * x / i;
                s = s + bieuthuc;
            }
            Console.WriteLine(decimal.Parse(s.ToString("0.00")));
        }
    }
}