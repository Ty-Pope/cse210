using System.Text.Json.Serialization;

public class ChecklistGoal : Goal
{
 private int _stepPoints;
 public int StepPoints { get { return _stepPoints; } }
 private int _steps;
 public int Steps { get { return _steps; } }
 private int _stepsCompleted;
 public int StepsCompleted { get { return _stepsCompleted; } set { _stepsCompleted = value; } }
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
   Console.WriteLine($"{Points} points added to your score.");
   IsComplete = true;
   return Points;
  }
  else
  {
   Console.WriteLine($"{_stepPoints} points added to your score.");
   return _stepPoints;
  }
 }
}