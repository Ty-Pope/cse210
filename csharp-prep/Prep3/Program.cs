using System;

class Program
{
 static void Main(string[] args)
 {
  bool gameOver = false;
  Random randomGenerator = new Random();
  int number = randomGenerator.Next(1, 101);
  while (!gameOver)
  {
   Console.Write("Guess a number between 1-100: ");
   string userNum = Console.ReadLine();
   int num = Int32.Parse(userNum);

   if (num == number)
   {
    Console.WriteLine("You guessed the number!");
    gameOver = true;
   }
   else if (num > number)
   {
    Console.WriteLine("Your guess is too high.");
   }
   else
   {
    Console.WriteLine("Your guess is too low.");
   }
  }
 }
}