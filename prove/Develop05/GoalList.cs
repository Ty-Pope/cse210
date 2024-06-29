using System.Text.Json.Serialization;

public class GoalList
{
 [JsonInclude]
 private List<SimpleGoal> simpleList;
 [JsonInclude]
 private List<EternalGoal> eternalList;
 [JsonInclude]
 private List<ChecklistGoal> checklistList;

 public GoalList()
 {
  simpleList = new List<SimpleGoal>();
  eternalList = new List<EternalGoal>();
  checklistList = new List<ChecklistGoal>();
 }
 public GoalList(List<SimpleGoal> simpleList, List<EternalGoal> eternalList, List<ChecklistGoal> checklistList)
 {
  this.simpleList = simpleList;
  this.eternalList = eternalList;
  this.checklistList = checklistList;
 }

 public void AddSimpleGoal(SimpleGoal goal)
 {
  simpleList.Add(goal);
 }
 public List<SimpleGoal> GetSimpleGoals()
 {
  return simpleList;
 }
 public void AddEternalGoal(EternalGoal goal)
 {
  eternalList.Add(goal);
 }
 public List<EternalGoal> GetEternalGoals()
 {
  return eternalList;
 }
 public void AddChecklistGoal(ChecklistGoal goal)
 {
  checklistList.Add(goal);
 }
 public List<ChecklistGoal> GetChecklistGoals()
 {
  return checklistList;
 }
 public Goal FindGoal(int id)
 {
  foreach (SimpleGoal s in simpleList)
  {
   if (s.GetId() == id)
   {
    return s;
   }
  }
  foreach (EternalGoal e in eternalList)
  {
   if (e.GetId() == id)
   {
    return e;
   }
  }
  foreach (ChecklistGoal c in checklistList)
  {
   if (c.GetId() == id)
   {
    return c;
   }
  }
  return null;
 }
 public void PrintGoal(Goal goal)
 {
  string goalString;
  if (goal.GetIsComplete() == true)
  {
   goalString = $"ID: {goal.GetId()} -- [X] --";
  }
  else
  {
   if (goal is ChecklistGoal cg)
   {
    if (cg.GetStepsCompleted() < cg.GetSteps())
    {
     goalString = $"ID: {goal.GetId()} -- [{cg.GetStepsCompleted()}/{cg.GetSteps()}] --";
    }
    else
    {
     goalString = $"ID: {goal.GetId()} -- [X] --";
    }
   }
   else
   {
    goalString = $"ID: {goal.GetId()} -- [ ] --";
   }
  }
  goalString += $" {goal.GetName()} -- {goal.GetPoints()} points";
  if (goal is ChecklistGoal check)
  {
   goalString += $" -- step points: {check.GetStepPoints()}";
  }
  Console.WriteLine(goalString);
 }
 public void PrintGoals(IEnumerable<Goal> goals)
 {
  foreach (Goal goal in goals)
  {
   PrintGoal(goal);
  }
 }


}