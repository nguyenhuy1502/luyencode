using System;
class HelloWorld {
  static void Main() {
     var numbers = Console.ReadLine();
        var numberList = numbers.Split(' ');
        var a = Convert.ToInt32(numberList[0]);
        var b = Convert.ToInt32(numberList[1]);
         var c = Convert.ToInt32(numberList[2]);
       if(a>=b && a>=c){
        Console.WriteLine(a);
       }
       else if(b>=a && b>=c){
        Console.WriteLine(b);
       }
       else{
         Console.WriteLine(c);
       }
  }
}