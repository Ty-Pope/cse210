public class EternalGoal : Goal
{
 private int _timesCompleted;
 public EternalGoal(string name, int points, int id) : base(name, points, id)
 {
  _timesCompleted = 0;
 }
 public override int CompleteTask()
 {
  Console.WriteLine($"{GetPoints()} points added to total score.");
  _timesCompleted += 1;
  return GetPoints();
 }
 public int GetTimesCompleted()
 {
  return _timesCompleted;
 }
}