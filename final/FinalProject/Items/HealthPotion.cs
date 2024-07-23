public class HealthPotion : Item
{
 private int _health;
 public HealthPotion(string _name, string _description, int health)
     : base(_name, _description)
 {
  _health = health;
 }
 public int GetHealth()
 {
  return _health;
 }
 public override void PrintItem()
 {
  Console.WriteLine("Name: " + GetName());
  Console.WriteLine("Description: " + GetDescription());
  Console.WriteLine("Healing Amount: " + _health);
 }
}