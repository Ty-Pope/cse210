public class BattleCondition
{
 public int _healthRequirement;
 public bool _isPlayer;
 public Weapon _giveWeapon;
 public string _description;
 public BattleCondition(int healthRequirement, bool isPlayer, Weapon giveWeapon, string description)
 {
  _healthRequirement = healthRequirement;
  _isPlayer = isPlayer;
  _giveWeapon = giveWeapon;
  _description = description;
 }
 public bool CheckCondition(Character character)
 {
  Text text = new Text();
  if (character.GetHealth() <= _healthRequirement)
  {
   text.WriteLine(_description);
   character.AddItem(_giveWeapon);
   character.SetWeapon(_giveWeapon);
   return true;
  }
  return false;
 }
}