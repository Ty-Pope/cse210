//This class really isn't needing to be a class but it's here to help reduce clutter in Program.cs
public class GameLevels
{
 private readonly Text _text = new();
 private Character _mainCharacter;

 public GameLevels(Character mainCharacter)
 {
  _mainCharacter = mainCharacter;
 }
 public void Intro()
 {
  Character otherBeing = new Character("???", 1, 1, new Inventory(), new List<Attack>());
  _text.WriteLine(otherBeing, "Hey! Hey! Wake up!");
  _text.WriteLine("[Press enter]");
  Console.ReadLine();
  _text.WriteLine("You: ...");
  _text.WriteLine(otherBeing, "Yes you! Wake up!");
  _text.WriteLine("[Press enter]");
  Console.ReadLine();
  _text.WriteLine("Your eyes open to a bright light.");
  _text.WriteLine(otherBeing, "Finally! It took you long enough. What's your name?");
  _text.WriteLine("Enter your name (this cannot be changed later): ");
  string name = Console.ReadLine();
  if (name == "")
  {
   name = "Player";
  }
  _mainCharacter.SetName(name);
  _mainCharacter.SetWeapon(new Weapon("Fists", "Your fists", 0));
  _mainCharacter.SetArmor(new Armor("Clothes", "Just the clothes on your back", 0));
  _text.WriteLine(otherBeing, $"Hello {_mainCharacter.GetName()}! I need your help to save the kingdom!");
  _text.WriteLine("The demon lord is planning on taking over the world.");
  _text.WriteLine("He has obtained amazing power and plans on using it to turn the world into darkness.");
  _text.WriteLine("Will you help?");
  Choice help = new Choice(["Yes", "No"]);
  int helpChoice = help.MakeChoice();
  if (helpChoice == 1)
  {
   _text.WriteLine("Yay!");
  }
  else if (helpChoice == 2)
  {
   _text.WriteLine(otherBeing, "...", 500);
   Thread.Sleep(500);
   _text.WriteLine(otherBeing, "...", 500);
   Thread.Sleep(500);
   _text.WriteLine(otherBeing, "...", 500);
   _text.WriteLine(otherBeing, "You know if you don't do this everyone is gonna die right?");
   _text.WriteLine(otherBeing, "So will you help?");
   Choice lastChance = new Choice(["Yes", "No"]);
   int lastChoice = lastChance.MakeChoice();
   if (lastChoice == 1)
   {
    _text.WriteLine(otherBeing, "I'm glad you came to your senses.");
   }
   else
   {
    _text.WriteLine(otherBeing, "Alright, whatever. Everyone is going to die and it'll be your fault.");
    //If i have time make this into a forced version where you fight the demon king but the game is a "hard mode"
    _text.WriteLine("The light disappears. Finally you can go back to falling asleep.");
    Thread.Sleep(750);
    _text.WriteLine("While you are sleeping, one of the demon lord's minions makes sure you never wake up again");
    _text.WriteLine("...", 500);
    GameOver();
   }
  }
  _mainCharacter.AddAttack(new Attack("Punch", 1, 0, 0));
 }
 public void Tutorial()
 {
  Character otherBeing = new Character("???", 1, 1, new Inventory(), new List<Attack>());
  _text.WriteLine(otherBeing, "Let's start your training!");
  _text.WriteLine("The light surrounds you. It's light is too intense. Suddenly, the light disappears to a soft glow.");
  _text.WriteLine("You open your eyes and see you're in a field.");
  _text.WriteLine("An orc stands in front of you, ready to fight.");
  List<Attack> orcAttack = [new Attack("Punch", 1, 0, 0)];
  Inventory orcInventory = new Inventory();
  Weapon fist = new Weapon("Fist", "", 0);
  orcInventory.AddItem(fist);
  Character orc = new Character("Orc", 12, 0, orcInventory, orcAttack);
  orc.SetSelectedWeapon(fist);
  Battle tutBattle = new Battle(_mainCharacter, orc, new BattleCondition(7, true, new Weapon("Sword", "A basic sword +1 damage attack", 1), "You're not gonna beat the orc at this point! Here, take this to boost your damage!"));
  tutBattle.BattleCycle();
  _text.WriteLine(otherBeing, "Good job! You beat the orc! Let me heal you!");
  _mainCharacter.SetHealth(10);
 }
 public void BossFight()
 {
  Character otherBeing = new Character("???", 1, 1, new Inventory(), new List<Attack>());
  _text.WriteLine(otherBeing, "So... due to some time constraints, we're gonna skip the rest of the training and the rest of the game that was planned and just jumping straight to the demon lord.");

  _text.WriteLine(otherBeing, "I'm going to give you some things to help you out!");
  Weapon legendarySword = new Weapon("Legendary Sword", "The most powerful sword. Forged from wizard steel and imbued with magical properties. +15 damage", 15);
  Armor legendaryArmor = new Armor("Legendary Armor", "The most powerful armor. Forged from dragon scales and imbued with magical properties. +10 defense", 10);
  _mainCharacter.AddItem(legendarySword);
  _mainCharacter.AddItem(legendaryArmor);

  Weapon pastWeapon = _mainCharacter.GetSelectedWeapon();
  Armor pastArmor = _mainCharacter.GetSelectedArmor();
  _mainCharacter.RemoveItem(pastWeapon);
  _mainCharacter.RemoveItem(pastArmor);

  _mainCharacter.SetWeapon(legendarySword);
  _mainCharacter.SetArmor(legendaryArmor);
  _text.WriteLine("Your previous weapon and armor have been removed and replaced.");

  _text.WriteLine("Your health has been increased to 50!");
  _mainCharacter.SetHealth(50);
  _mainCharacter.SetMaxHealth(50);
  _text.WriteLine("Your mana has been increased to 20!");
  _mainCharacter.SetMana(20);
  _text.WriteLine("You've been given 5 health potions!");
  for (int i = 0; i < 5; i++)
  {
   _mainCharacter.AddItem(new HealthPotion("Health Potion", "Heals 10 health", 10));
  }

  _mainCharacter.AddAttack(new Attack("Fireball", 20, 10, 0));
  _text.WriteLine("Here are your attacks now!");
  _mainCharacter.ListBasicAttacks();


  _text.WriteLine(otherBeing, "You're ready to fight the demon lord!");
  _text.WriteLine("The light surrounds you. It's light is too intense. Suddenly, the light disappears to a soft glow.");
  _text.WriteLine("You open your eyes and see you're in the demon lord's fortress.");
  _text.WriteLine("The demon lord stands in front of you, ready to fight.");
  List<Attack> demonAttacks = [new Attack("Punch", 10, 0, 0), new Attack("Bite", 15, 0, 0), new Attack("Glare Menacingly", 1, 0, 0)];
  Inventory demonInventory = new Inventory();
  Weapon demonFist = new Weapon("Demon Fist", "", 9);
  Armor demonArmor = new Armor("Demon Armor", "", 9);
  demonInventory.AddItem(demonFist);
  demonInventory.AddItem(demonArmor);
  Character demon = new Character("Demon Lord", 70, 0, demonInventory, demonAttacks);
  demon.SetSelectedWeapon(demonFist);
  demon.SetSelectedArmor(demonArmor);
  _text.WriteLine(demon, "How did you get here?");
  _text.WriteLine(otherBeing, "Good luck!");
  Battle bossBattle = new Battle(_mainCharacter, demon, null);
  bossBattle.BattleCycle();
  _text.WriteLine(otherBeing, "Good job! You beat the demon lord! You saved the kingdom!");
  _text.WriteLine("The light surrounds you. It's light is too intense. Suddenly, the light disappears to a soft glow.");
  _text.WriteLine("You open your eyes and see that you're back laying on your bed.");
  _text.WriteLine("Finally, some time to sleep.");
  GameOver();
 }
 public void GameOver()
 {
  //Copied ascii art from this stack overflow question:
  //https://stackoverflow.com/questions/55252683/ascii-text-printing-out-of-order-in-my-text-based-game
  _text.WriteLine("  _____                         ____                 ", 1);
  _text.WriteLine(" / ____|                       / __ \\                ", 1);
  _text.WriteLine("| |  __  __ _ _ __ ___   ___  | |  | |_   _____ _ __ ", 1);
  _text.WriteLine("| | |_ |/ _` | '_ ` _ \\ / _ \\ | |  | \\ \\ / / _ \\ '__|", 1);
  _text.WriteLine("| |__| | (_| | | | | | |  __/ | |__| |\\ V /  __/ |   ", 1);
  _text.WriteLine(" \\_____|\\__,_|_| |_| |_|\\___|  \\____/  \\_/ \\___|_|   ", 1);
  Environment.Exit(0);
 }
}