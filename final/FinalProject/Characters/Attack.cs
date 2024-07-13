public class Attack
{
 private string name;
 private int damage;
 private int manaCost;
 private int splashDamage;
 private int level;
 public Attack(string name, int damage, int manaCost, int splashDamage, int level)
 {
  this.name = name;
  this.damage = damage;
  this.manaCost = manaCost;
  this.splashDamage = splashDamage;
  this.level = level;
 }
 public string GetName()
 {
  return name;
 }
 public int GetDamage()
 {
  return damage;
 }
 public int GetManaCost()
 {
  return manaCost;
 }
 public int GetSplashDamage()
 {
  return splashDamage;
 }
 public bool CanAttack(int currentMana)
 {
  return currentMana >= manaCost;
 }
 public bool IsUnderleveled(int level)
 {
  return this.level < level;
 }
}