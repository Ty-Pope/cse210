using System;

class Program
{
 static void Main(string[] args)
 {
  DisplayWelcome();
  string name = PromptUserName();
  int num = PromptUserNumber();
  num = SquareNumber(num);
  DisplayResult(num, name);
 }
 static void DisplayWelcome()
 {
  Console.WriteLine("Welcome to the Program!");
 }
 static string PromptUserName()
 {
  Console.Write("Enter your name: ");
  string name = Console.ReadLine();
  return name;
 }
 static int PromptUserNumber()
 {
  Console.Write("Enter your favorite number: ");
  int number = int.Parse(Console.ReadLine());
  return number;
 }
 static int SquareNumber(int num)
 {
  return num * num;
 }
 static void DisplayResult(int num, string name)
 {
  Console.Write($"{name}, the square of your number is {num}");
 }
}