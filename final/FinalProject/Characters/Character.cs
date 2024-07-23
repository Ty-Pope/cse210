public class Character
{
 private Text _text = new Text();
 private string _name;
 private int _health;
 private int _maxHealth;
 private int _mana;
 private Inventory _inventory;
 private List<Attack> _basicAttacks;
 private Weapon _selectedWeapon;
 private Armor _selectedArmor;
 public Character(string name, int health, int mana, Inventory inventory, List<Attack> basicAttacks, Weapon selectedWeapon = null, Armor selectedArmor = null)
 {
  _name = name;
  _health = health;
  _maxHealth = health;
  _mana = mana;
  _inventory = inventory;
  _basicAttacks = basicAttacks;
 }
 public void SetSelectedWeapon(Weapon weapon)
 {
  _selectedWeapon = weapon;
 }
 public void SetSelectedArmor(Armor armor)
 {
  _selectedArmor = armor;
 }
 public int GetMaxHealth()
 {
  return _maxHealth;
 }
 public void SetMaxHealth(int maxHealth)
 {
  _maxHealth = maxHealth;
 }
 public void SetName(string name)
 {
  _name = name;
 }
 public string GetName()
 {
  return _name;
 }
 public int GetHealth()
 {
  return _health;
 }
 public void Damage(int damage)
 {
  _health -= damage;
 }
 public bool IsDead()
 {
  return _health <= 0;
 }
 public int GetMana()
 {
  return _mana;
 }
 public Inventory GetInventory()
 {
  return _inventory;
 }
 public void PrintInventory()
 {
  _inventory.PrintInventory();
 }
 public void PrintCharacter()
 {
  _text.WriteLine("Name: " + GetName());
  _text.WriteLine("Health: " + GetHealth());
  _text.WriteLine("Mana: " + GetMana());
  _text.WriteLine("Inventory: ");
  PrintInventory();
  ListBasicAttacks();
 }
 public void PrintNameAndHealth()
 {
  _text.Write("Name: " + GetName());
  _text.Write(" --- Health: " + GetHealth());
 }
 public void ListBasicAttacks()
 {
  int i = 1;
  foreach (Attack attack in _basicAttacks)
  {
   _text.WriteLine("[" + i + "] - " + attack.GetName());
   _text.WriteLine(attack.GetDamage() + " damage");
   _text.WriteLine(attack.GetManaCost() + " mana cost");
   i++;
  }
 }
 public List<Attack> GetAttacks()
 {
  return _basicAttacks;
 }
 public Attack GetAttack(int attack)
 {
  return _basicAttacks[attack];
 }
 public void AddAttack(Attack attack)
 {
  _basicAttacks.Add(attack);
 }
 public void RemoveAttack(Attack attack)
 {
  _basicAttacks.Remove(attack);
 }
 public Weapon GetSelectedWeapon()
 {
  return _selectedWeapon;
 }
 public Armor GetSelectedArmor()
 {
  return _selectedArmor;
 }
 public void SetWeapon(Weapon weapon)
 {
  _selectedWeapon = weapon;
 }
 public void SetArmor(Armor armor)
 {
  _selectedArmor = armor;
 }
 public void AddItem(Item item)
 {
  _text.WriteLine("You found a " + item.GetName());
  _inventory.AddItem(item);
 }
 public void RemoveItem(Item item)
 {
  _inventory.RemoveItem(item);
 }
 public List<string> GetAttackNames()
 {
  List<string> attackNames = new List<string>();
  foreach (Attack attack in _basicAttacks)
  {
   attackNames.Add(attack.GetName());
  }
  return attackNames;
 }
 public void SetHealth(int health)
 {
  _health = health;
 }
 public void SetMana(int mana)
 {
  _mana = mana;
 }
}