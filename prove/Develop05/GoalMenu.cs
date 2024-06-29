using System.Text.Json;

public class GoalMenu
{
 private int totalPoints;
 private GoalList goals;
 private string path = null;
 public GoalMenu()
 {
  totalPoints = 0;
  goals = new GoalList();
 }
 public void ListGoals()
 {
  List<SimpleGoal> sGoal = goals.GetSimpleGoals();
  List<ChecklistGoal> cGoal = goals.GetChecklistGoals();
  List<EternalGoal> eGoal = goals.GetEternalGoals();

  Console.WriteLine("Simple Goals: ");
  goals.PrintGoals(sGoal);
  Console.WriteLine("Checklist Goals: ");
  goals.PrintGoals(cGoal);
  Console.WriteLine("Eternal Goals: ");
  goals.PrintGoals(eGoal);
 }
 public void AddGoal()
 {
  Console.Clear();
  Console.WriteLine("What type of goal would you like to make?");
  Console.WriteLine("1. Simple Goal");
  Console.WriteLine("2. Checklist Goal (have to do it multiple times)");
  Console.WriteLine("3. Eternal Goal");
  int goalInt = Convert.ToInt32(Console.ReadLine());
  Console.WriteLine("Enter the goal name:");
  string goalName = Console.ReadLine();
  Console.WriteLine("Enter the completion points for the goal:");
  int goalPoints = Convert.ToInt32(Console.ReadLine());
  switch (goalInt)
  {
   case 1:
    goals.AddSimpleGoal(new SimpleGoal(goalName, goalPoints, goals.GetSimpleGoals().Count + goals.GetChecklistGoals().Count + goals.GetEternalGoals().Count));
    Console.WriteLine("Goal Created");
    break;
   case 2:
    Console.WriteLine("Enter a step's completion points:");
    int goalStepPoints = Convert.ToInt32(Console.ReadLine());
    Console.WriteLine("Enter how many times the goal should be completed:");
    int goalSteps = Convert.ToInt32(Console.ReadLine());
    goals.AddChecklistGoal(new ChecklistGoal(goalName, goalPoints, goalStepPoints, goalSteps, goals.GetSimpleGoals().Count + goals.GetChecklistGoals().Count + goals.GetEternalGoals().Count));
    break;
   case 3:
    goals.AddEternalGoal(new EternalGoal(goalName, goalPoints, goals.GetSimpleGoals().Count + goals.GetChecklistGoals().Count + goals.GetEternalGoals().Count));
    break;
  }
 }

 public void CompleteGoal()
 {
  Console.WriteLine("Enter the goals id:");
  int id = Convert.ToInt32(Console.ReadLine());
  Goal goal = goals.FindGoal(id);
  if (goal != null)
  {
   if (goal.IsComplete)
   {
    Console.WriteLine("This goal has already been completed. Pick another goal to complete.");
   }
   else
   {
    totalPoints += goal.CompleteTask();
   }
  }
  else
  {
   Console.WriteLine("A goal with that ID does not exist.");
  }
 }
 public bool Menu()
 {
  int goalNum = 0;
  while (goalNum != 1 && goalNum != 2 && path == null)
  {
   Console.WriteLine("Would you like to:\n1. Create a new goals list\n2. Load a goals list");
   goalNum = Convert.ToInt32(Console.ReadLine());
   switch (goalNum)
   {
    case 1:
     Console.WriteLine("Enter a path where you want your goals saved:");
     path = Console.ReadLine();
     break;
    case 2:
     LoadGoals();
     break;
   }
  }
  Console.WriteLine($"You have {totalPoints} total points.");
  Console.WriteLine("1. List goals");
  Console.WriteLine("2. Add goal");
  Console.WriteLine("3. Complete goal");
  Console.WriteLine("4. Load goals file");
  Console.WriteLine("5. Exit");
  int choice = Convert.ToInt32(Console.ReadLine());
  Console.Clear();
  switch (choice)
  {
   case 1:
    ListGoals();
    break;
   case 2:
    AddGoal();
    break;
   case 3:
    CompleteGoal();
    break;
   case 4:
    LoadGoals();
    break;
   case 5:
    return false;
  }
  SaveFile();
  return true;
 }
 public void LoadGoals()
 {
  Console.WriteLine("Enter file path:");
  path = Console.ReadLine();
  string jsonStringFromFile = File.ReadAllText(path);
  goals = JsonSerializer.Deserialize<GoalList>(jsonStringFromFile);
  SetTotalPoints();
 }
 public void SaveFile()
 {
  string jsonString = JsonSerializer.Serialize(goals);
  File.WriteAllText(path, jsonString);
 }
 public void SetTotalPoints()
 {
  totalPoints = 0;
  foreach (SimpleGoal sg in goals.GetSimpleGoals())
  {
   totalPoints += GetPoints(sg);
  }
  foreach (EternalGoal eg in goals.GetEternalGoals())
  {
   totalPoints += GetPoints(eg);
  }
  foreach (ChecklistGoal cg in goals.GetChecklistGoals())
  {
   totalPoints += GetPoints(cg);
  }
 }
 private int GetPoints(Goal g)
 {
  if (g.IsComplete && g is ChecklistGoal cg)
  {
   return cg.StepPoints * (cg.Steps - 1) + cg.Points;
  }
  else if (g is EternalGoal eg)
  {
   return eg.Points * eg.TimesCompleted;
  }
  else if (g.IsComplete)
  {
   return g.Points;
  }
  return 0;
 }
}