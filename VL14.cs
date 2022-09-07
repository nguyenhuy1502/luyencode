using System;
class HelloWorld {
  static void Main() {
    string s = Console.ReadLine();
    var s1 = s.Split(' ');
    int a = Convert.ToInt32(s1[0]);
    int b = Convert.ToInt32(s1[1]);
    int uscln=0;
         for (int i = 1; i <=10000; i++)
            {
                if (a % i == 0 && b % i == 0)
                {
                    uscln = i;
                }
            }
           Console.WriteLine(uscln);
  }
}