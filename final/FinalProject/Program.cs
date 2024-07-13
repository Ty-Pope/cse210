class Program
{
 static void Main(string[] args)
 {
  //Some room descriptions are generated using ChatGPT and then edited by me to make it fit with the story.
  GameLevels gl = new();
  gl.GameOver();
  Character main = gl.Intro();
  //if they choose to adventure
  if (main != null)
  {
   gl.Tutorial();
  }
  else
  {
   gl.GameOver();
  }
 }
}