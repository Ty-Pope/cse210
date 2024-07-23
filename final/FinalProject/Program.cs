class Program
{
 static void Main(string[] args)
 {
  GameLevels gl = new GameLevels(new Character("", 10, 10, new Inventory(), new List<Attack>()));
  gl.Intro();
  gl.Tutorial();
  gl.BossFight();
 }
}