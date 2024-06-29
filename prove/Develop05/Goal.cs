public abstract class Goal
{
 private bool _isComplete;
 public bool IsComplete { get { return _isComplete; } set { _isComplete = value; } }
 private string _name;
 public string Name { get { return _name; } set { _name = value; } }
 private int _points;
 public int Points { get { return _points; } set { _points = value; } }
 private int _id;
 public int Id { get { return _id; } set { _id = value; } }
 public Goal(string name, int points, int id)
 {
  _name = name;
  _points = points;
  _isComplete = false;
  _id = id;
 }
 public abstract int CompleteTask();
}