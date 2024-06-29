public class EternalGoal : Goal
{
 private int _timesCompleted;
 public int TimesCompleted { get { return _timesCompleted; } set { _timesCompleted = value; } }
 public EternalGoal(string name, int points, int id) : base(name, points, id)
 {
  _timesCompleted = 0;
 }
 public override int CompleteTask()
 {
  Console.WriteLine($"{Points} points added to total score.");
  _timesCompleted += 1;
  return Points;
 }
}