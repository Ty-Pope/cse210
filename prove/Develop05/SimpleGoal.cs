public class SimpleGoal : Goal
{
 public SimpleGoal(string name, int points, int id) : base(name, points, id) { }
 public override int CompleteTask()
 {
  IsComplete = true;
  Console.WriteLine("You have completed this goal!");
  Console.WriteLine($"{Points} points added to your score.");
  IsComplete = true;
  return Points;
 }
}