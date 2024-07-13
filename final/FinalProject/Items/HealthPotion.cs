public class HealthPotion : Item
{
 private int health;
 public HealthPotion(string name, string value, string description, int health)
     : base(name, value, description)
 {
  this.health = health;
 }
 public int GetHealth()
 {
  return health;
 }
 public override void PrintItem()
 {
  Console.WriteLine("Name: " + GetName());
  Console.WriteLine("Value: " + GetValue());
  Console.WriteLine("Description: " + GetDescription());
  Console.WriteLine("Healing Amount: " + health);
 }
}