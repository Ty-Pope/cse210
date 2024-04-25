using System;
class Program
{
 static void Main(string[] args)
 {
  Console.Write("Enter your grade: ");
  string userInput = Console.ReadLine();
  int inputGrade = int.Parse(userInput);
  string letter = "";
  bool pass = true;
  if (inputGrade >= 90)
  {
   letter = "A";
  }
  else if (inputGrade >= 80)
  {
   letter = "B";
  }
  else if (inputGrade >= 70)
  {
   letter = "C";
  }
  else if (inputGrade >= 60)
  {
   letter = "D";
   pass = false;
  }
  else
  {
   letter = "F";
   pass = false;
  }

  if (pass)
  {
   Console.WriteLine($"You passed the class with an {letter}.");
  }
  else
  {
   Console.WriteLine($"You failed the class with an {letter}");
  }
 }
}