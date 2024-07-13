//This class really isn't needing to be a class but it's here to help reduce clutter in Program
public class GameLevels
{
 private readonly Text text = new();
 public Character Intro()
 {
  Character otherBeing = new Character("???", 1, 1, new Inventory(), new List<Attack>());
  text.WriteLine(otherBeing, "Hey! Hey! Wake up!");
  text.WriteLine("[Press enter]");
  Console.ReadLine();
  text.WriteLine("You: ...");
  text.WriteLine(otherBeing, "Yes you! Wake up!");
  text.WriteLine("[Press enter]");
  Console.ReadLine();
  text.WriteLine("Your eyes open to a bright light.");
  text.WriteLine(otherBeing, "Finally! It took you long enough. What's your name?");
  text.WriteLine("Enter your name (this cannot be changed later): ");
  string name = Console.ReadLine();
  Character mainCharacter = new Character(name, 10, 10, new Inventory(), new List<Attack>());
  text.WriteLine(otherBeing, $"Hello {mainCharacter.GetName()}! I need your help to save the kingdom!");
  text.WriteLine("The demon lord [enter demon lord here TODO] is planning on taking over the world.");
  text.WriteLine("He has obtained the power of the south star and plans on using it to turn the world into darkness.");
  text.WriteLine("Will you help?");
  Choice help = new Choice(["Yes", "No"]);
  int helpChoice = help.MakeChoice();
  if (helpChoice == 1)
  {
   text.WriteLine("Yay!");
  }
  else if (helpChoice == 2)
  {
   text.WriteLine(otherBeing, "...", 500);
   Thread.Sleep(500);
   text.WriteLine(otherBeing, "...", 500);
   Thread.Sleep(500);
   text.WriteLine(otherBeing, "...", 500);
   text.WriteLine(otherBeing, "You know if you don't do this everyone is gonna die right?");
   text.WriteLine(otherBeing, "So will you help?");
   Choice lastChance = new Choice(["Yes", "No"]);
   int lastChoice = lastChance.MakeChoice();
   if (lastChoice == 1)
   {
    text.WriteLine(otherBeing, "I'm glad you came to your senses.");
   }
   else
   {
    text.WriteLine(otherBeing, "Alright, whatever. Everyone is going to die and it'll be your fault.");
    //If i have time make this into a forced version where you fight the demon king but the game is a "hard mode"
    text.WriteLine("The light disappears. Finally you can go back to falling asleep.");
    Thread.Sleep(750);
    text.WriteLine("While you are sleeping, one of the demon lord's minions makes sure you never wake up again");
    text.WriteLine("...", 500);
    return null;
   }
  }
  return mainCharacter;
 }
 public void Tutorial()
 {
  Character otherBeing = new Character("???", 1, 1, new Inventory(), new List<Attack>());
  text.WriteLine(otherBeing, "Let's start your training!");
  text.WriteLine("The light surrounds you. It's light is too intense. Suddenly, the light disappears to a soft glow.");
  text.WriteLine("You open your eyes and see you're in a field.");
  text.WriteLine("An orc stands in front of you, ready to fight.");
 }
 //Make this a choice that has restart game, start from last save, and have it as ascii art.s
 public void GameOver()
 {
  //Copied ascii art from this stack overflow question:
  //https://stackoverflow.com/questions/55252683/ascii-text-printing-out-of-order-in-my-text-based-game
  text.WriteLine("  _____                         ____                 ", 1);
  text.WriteLine(" / ____|                       / __ \\                ", 1);
  text.WriteLine("| |  __  __ _ _ __ ___   ___  | |  | |_   _____ _ __ ", 1);
  text.WriteLine("| | |_ |/ _` | '_ ` _ \\ / _ \\ | |  | \\ \\ / / _ \\ '__|", 1);
  text.WriteLine("| |__| | (_| | | | | | |  __/ | |__| |\\ V /  __/ |   ", 1);
  text.WriteLine(" \\_____|\\__,_|_| |_| |_|\\___|  \\____/  \\_/ \\___|_|   ", 1);
  Environment.Exit(0);
 }
}