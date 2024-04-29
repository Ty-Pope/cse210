using System;

class Program
{
 static void Main(string[] args)
 {
  bool finish = false;
  List<int> arr = new List<int>();
  while (!finish)
  {
   Console.Write("Enter a number: ");
   string num = Console.ReadLine();
   int arrNum = int.Parse(num);
   arr.Add(arrNum);
   if (arrNum == 0)
   {
    int sum = 0;
    foreach (int number in arrNum)
    {
     sum += number;
    }
    Console.WriteLine($"Your total is: {sum}");
    finish = true;
   }
  }
 }
}