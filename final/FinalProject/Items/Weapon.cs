public class Weapon : Item
{
 private int _damage;

 public Weapon(string _name, string _description, int damage)
  : base(_name, _description)
 {
  _damage = damage;
 }
 public int GetDamage()
 {
  return _damage;
 }
 public override void PrintItem()
 {
  Console.WriteLine("Name: " + GetName());
  Console.WriteLine("Description: " + GetDescription());
  Console.WriteLine("Damage Bonus: " + _damage);
 }
}