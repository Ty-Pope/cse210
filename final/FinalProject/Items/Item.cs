public abstract class Item
{
 private string _name;
 private string _description;

 public Item(string name, string description)
 {
  _name = name;
  _description = description;
 }
 public string GetName()
 {
  return _name;
 }
 public string GetDescription()
 {
  return _description;
 }

 public abstract void PrintItem();
}