public class Choice
{
 private List<string> options;
 Text text;
 public Choice(List<string> options)
 {
  this.options = options;
  this.text = new Text();
 }
 public void PrintOptions()
 {
  int choiceNum = 0;
  foreach (string option in options)
  {
   choiceNum++;
   text.WriteLine($"{choiceNum}. {option}");
  }
 }
 public int MakeChoice()
 {
  PrintOptions();
  int choice = 0;
  while (choice < 1 || choice > options.Count())
  {
   try
   {
    text.WriteLine("Choose an option:");
    choice = Convert.ToInt32(Console.ReadLine());
   }
   catch
   {
    Console.Write("Enter a number and make sure to ");
   }
   if (choice > 0 && choice <= options.Count())
   {
    break;
   }
   else
   {
    text.WriteLine("Pick a number between 1 and " + options.Count());
   }
  }
  return choice;
 }
}