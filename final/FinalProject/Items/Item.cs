public abstract class Item
{
 private string name;
 private string value;
 private string description;

 public Item(string name, string value, string description)
 {
  this.name = name;
  this.value = value;
  this.description = description;
 }
 public string GetName()
 {
  return name;
 }
 public string GetValue()
 {
  return value;
 }
 public string GetDescription()
 {
  return description;
 }

 public abstract void PrintItem();
}