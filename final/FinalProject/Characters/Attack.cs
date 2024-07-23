public class Attack
{
 private string _name;
 private int _damage;
 private int _manaCost;
 private int _splashDamage;
 public Attack(string name, int damage, int manaCost, int splashDamage)
 {
  _name = name;
  _damage = damage;
  _manaCost = manaCost;
  _splashDamage = splashDamage;
 }
 public string GetName()
 {
  return _name;
 }
 public int GetDamage()
 {
  return _damage;
 }
 public int GetManaCost()
 {
  return _manaCost;
 }
 public int GetSplashDamage()
 {
  return _splashDamage;
 }
 public bool CanAttack(int currentMana)
 {
  return currentMana >= _manaCost;
 }
}