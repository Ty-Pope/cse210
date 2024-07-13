public class Armor : Item
{
 private int defense;
 public Armor(string name, string value, string description, int defense)
     : base(name, value, description)
 {
  this.defense = defense;
 }
 public int GetDefense()
 {
  return defense;
 }
 public override void PrintItem()
 {
  Console.WriteLine("Name: " + GetName());
  Console.WriteLine("Value: " + GetValue());
  Console.WriteLine("Description: " + GetDescription());
  Console.WriteLine("Defense: " + defense);
 }
}