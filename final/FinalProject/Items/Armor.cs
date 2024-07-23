public class Armor : Item
{
 private int _defense;
 public Armor(string _name, string _description, int defense)
     : base(_name, _description)
 {
  _defense = defense;
 }
 public int GetDefense()
 {
  return _defense;
 }
 public override void PrintItem()
 {
  Console.WriteLine("Name: " + GetName());
  Console.WriteLine("Description: " + GetDescription());
  Console.WriteLine("Defense: " + _defense);
 }
}