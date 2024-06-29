using System;

class Program
{
 static void Main(string[] args)
 {
  GoalMenu goalMenu = new GoalMenu();
  bool isFinished = true;
  while (isFinished)
  {
   isFinished = goalMenu.Menu();
  }
 }
}