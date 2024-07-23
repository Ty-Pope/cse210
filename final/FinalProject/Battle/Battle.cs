public class Battle
{
 private Character _player;
 private Character _enemy;
 private BattleCondition _battleCondition;
 private bool _conditionMet = false;

 public Battle(Character player, Character enemy, BattleCondition bc)
 {
  _player = player;
  _enemy = enemy;
  _battleCondition = bc;
 }

 public bool BattleCycle()
 {
  Text t = new Text();
  while (!_player.IsDead() && !_enemy.IsDead())
  {
   _player.PrintNameAndHealth();
   t.Write(" vs. ");
   _enemy.PrintNameAndHealth();
   Console.WriteLine("");
   List<string> test = _player.GetAttackNames();
   List<string> playerAttacks = _player.GetAttackNames();
   bool addedPotion = false;
   if (_player.GetInventory().GetItemByName("Health Potion") != null)
   {
    playerAttacks.Add("Use Health Potion");
    addedPotion = true;
   }
   playerAttacks.Add("Player Info");
   Choice choice = new Choice(playerAttacks);
   int battleChoice = choice.MakeChoice();
   if (battleChoice >= playerAttacks.Count - 1 && addedPotion == true)
   {
    Test(addedPotion, battleChoice, playerAttacks, t);
   }
   else if (battleChoice == playerAttacks.Count && addedPotion == false)
   {
    //This is here for in case the player has no potions
    Test(addedPotion, battleChoice, playerAttacks, t);
   }
   else
   {
    Attack attack = _player.GetAttack(battleChoice - 1);
    if (attack.GetManaCost() > _player.GetMana())
    {
     t.WriteLine("Not enough mana!");
     continue;
    }
    _player.SetMana(_player.GetMana() - attack.GetManaCost());
    Armor enemyArmor = _enemy.GetSelectedArmor();
    if (enemyArmor == null)
    {
     enemyArmor = new Armor("None", "No armor", 0);
    }
    int playerDamage = CalculateDamage(attack, _player, enemyArmor);
    t.WriteLine("You attack " + _enemy.GetName() + " with " + attack.GetName() + " for " + playerDamage + " damage!");
    _enemy.Damage(playerDamage);
    if (_enemy.IsDead())
    {
     t.WriteLine("You win!");
     return true;
    }
    int attackIndexEnemy = new Random().Next(0, _enemy.GetAttacks().Count);
    int enemyDamage = CalculateDamage(_enemy.GetAttack(attackIndexEnemy), _enemy, _player.GetSelectedArmor());
    t.WriteLine(_enemy.GetName() + " attacks you with " + _enemy.GetAttack(attackIndexEnemy).GetName() + " for " + enemyDamage + " damage!");
    _player.Damage(enemyDamage);
    if (_battleCondition != null)
    {
     if (_conditionMet == false)
     {
      _conditionMet = _battleCondition.CheckCondition(_player);
      if (_conditionMet == true)
      {
       _player.RemoveAttack(_player.GetAttack(0));
       _player.AddAttack(new Attack("Sword Slash", 1, 0, 0));
      }
     }
    }
    if (_player.IsDead())
    {
     return false;
    }
   }
  }
  return true;
 }
 public int CalculateDamage(Attack attack, Character attacker, Armor defense)
 {
  int damage = attack.GetDamage();
  int bonus = attacker.GetSelectedWeapon().GetDamage();
  int defence = defense.GetDefense();
  return damage + bonus - defence;
 }
 private void Test(bool addedPotion, int battleChoice, List<string> playerAttacks, Text t)
 {
  if (addedPotion == true && battleChoice == playerAttacks.Count - 1)
  {
   if (_player.GetMaxHealth() <= _player.GetHealth())
   {
    t.WriteLine("You are already at full health!");
    return;
   }
   Item healthPotion = _player.GetInventory().GetItemByName("Health Potion");
   if (healthPotion != null && healthPotion is HealthPotion)
   {
    HealthPotion potion = (HealthPotion)healthPotion;
    _player.SetHealth(_player.GetHealth() + potion.GetHealth());
    _player.GetInventory().RemoveItem(healthPotion);
    t.WriteLine("You used a health potion and gained " + potion.GetHealth() + " health!");
   }
   else
   {
    t.WriteLine("You don't have any health potions!");
   }
  }
  else
  {
   _player.PrintCharacter();
  }
 }
}