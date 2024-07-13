public class Battle
{
 private Character _player;
 private Character _enemy;

 public Battle(Character player, Character enemy)
 {
  _player = player;
  _enemy = enemy;
 }

 public bool BattleCycle()
 {
  while (!_player.IsDead() && !_enemy.IsDead())
  {
   _player.PrintCharacter();
   _enemy.PrintCharacter();
   Console.WriteLine("Choose an attack:");
   _player.ListBasicAttacks();
   int attackIndex = Convert.ToInt32(Console.ReadLine());
   Attack attack = _player.GetAttack(attackIndex);
   _enemy.Damage(attack.GetDamage() + _player.GetSelectedWeapon().GetDamage() - _enemy.GetSelectedArmor().GetDefense());

   if (_enemy.IsDead())
   {
    Console.WriteLine("You win!");
    return true;
   }
   int attackIndexEnemy = new Random().Next(0, _enemy.GetAttacks().Count);
   _player.Damage(_enemy.GetAttack(attackIndexEnemy).GetDamage());
   if (_player.IsDead())
   {
    Console.WriteLine("You lose!");
    return false;
   }
  }
  return true;
 }
}