public class Character
{
 private string name;
 private int health;
 private int mana;
 private Inventory inventory;
 private List<Attack> basicAttacks;
 private Weapon selectedWeapon;
 private Armor selectedArmor;
 public Character(string name, int health, int mana, Inventory inventory, List<Attack> basicAttacks)
 {
  this.name = name;
  this.health = health;
  this.mana = mana;
  this.inventory = inventory;
  this.basicAttacks = basicAttacks;
 }
 public string GetName()
 {
  return name;
 }
 public int GetHealth()
 {
  return health;
 }
 public void Damage(int damage)
 {
  health -= damage;
 }
 public bool IsDead()
 {
  return health <= 0;
 }
 public int GetMana()
 {
  return mana;
 }
 public Inventory GetInventory()
 {
  return inventory;
 }
 public void PrintCharacter()
 {
  Console.WriteLine("Name: " + GetName());
  Console.WriteLine("Health: " + GetHealth());
  Console.WriteLine("Mana: " + GetMana());
  Console.WriteLine("Inventory: " + GetInventory());
  ListBasicAttacks();
 }
 public void ListBasicAttacks()
 {
  int i = 0;
  foreach (Attack attack in basicAttacks)
  {
   Console.WriteLine("[" + i + "] - " + attack.GetName());
   Console.WriteLine(attack.GetDamage() + " damage");
   Console.WriteLine(attack.GetManaCost() + " mana cost");
  }
 }
 public List<Attack> GetAttacks()
 {
  return basicAttacks;
 }
 public Attack GetAttack(int attack)
 {
  return basicAttacks[attack];
 }
 public Weapon GetSelectedWeapon()
 {
  return selectedWeapon;
 }
 public Armor GetSelectedArmor()
 {
  return selectedArmor;
 }
 public void SetWeapon(Weapon weapon)
 {
  selectedWeapon = weapon;
 }
 public void SetArmor(Armor armor)
 {
  selectedArmor = armor;
 }
}