using System;

namespace a
{
    class Program
    {
        static void Main(string[] args)
        {
            string s1 = Console.ReadLine();
            int n = Convert.ToInt32(s1);
            int s = 0;
            for (int i = 1; i <= 3*n+1; i++)
            {
                switch (i % 2)
                {
                    case 0:
                        s = s - i;
                        break;
                    case 1:
                        s = s + i;
                        break;
                }
            }
            Console.WriteLine(s);
        }
    }
}