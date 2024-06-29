public class SimpleGoal : Goal
{
 public SimpleGoal(string name, int points, int id) : base(name, points, id) { }
 public override int CompleteTask()
 {
  SetIsComplete(true);
  Console.WriteLine("You have completed this goal!");
  Console.WriteLine($"{GetPoints()} points added to your score.");
  return GetPoints();
 }
}