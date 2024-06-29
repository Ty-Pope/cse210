using System.Text.Json.Serialization;

public class ChecklistGoal : Goal
{
 private int _stepPoints;
 private int _steps;
 private int _stepsCompleted;
 public ChecklistGoal(string name, int points, int stepPoints, int steps, int id) : base(name, points, id)
 {
  _stepPoints = stepPoints;
  _steps = steps;
  _stepsCompleted = 0;
 }

 public override int CompleteTask()
 {
  _stepsCompleted++;
  if (_steps == _stepsCompleted)
  {
   Console.WriteLine("You have completed this goal!");
   Console.WriteLine($"{GetPoints()} points added to your score.");
   SetIsComplete(true);
   return GetPoints();
  }
  else
  {
   Console.WriteLine($"{_stepPoints} points added to your score.");
   return _stepPoints;
  }
 }
 public int GetStepPoints()
 {
  return _stepPoints;
 }

 public int GetSteps()
 {
  return _steps;
 }

 public int GetStepsCompleted()
 {
  return _stepsCompleted;
 }
}