public class Weapon : Item
{
 private int damage;

 public Weapon(string name, string value, string description, int damage)
  : base(name, value, description)
 {
  this.damage = damage;
 }
 public int GetDamage()
 {
  return damage;
 }
 public override void PrintItem()
 {
  Console.WriteLine("Name: " + GetName());
  Console.WriteLine("Value: " + GetValue());
  Console.WriteLine("Description: " + GetDescription());
  Console.WriteLine("Damage Bonus: " + damage);
 }
}