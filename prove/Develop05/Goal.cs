public abstract class Goal
{
 private bool _isComplete;
 private string _name;
 private int _points;
 private int _id;
 public Goal(string name, int points, int id)
 {
  _name = name;
  _points = points;
  _isComplete = false;
  _id = id;
 }
 public abstract int CompleteTask();

 public bool GetIsComplete()
 {
  return _isComplete;
 }

 public void SetIsComplete(bool isComplete)
 {
  _isComplete = isComplete;
 }

 public string GetName()
 {
  return _name;
 }

 public int GetPoints()
 {
  return _points;
 }

 public int GetId()
 {
  return _id;
 }
}