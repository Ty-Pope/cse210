public class Choice
{
 private List<string> _options;
 Text _text;
 public Choice(List<string> options)
 {
  _options = options;
  _text = new Text();
 }
 public void PrintOptions()
 {
  int choiceNum = 0;
  foreach (string option in _options)
  {
   choiceNum++;
   _text.WriteLine($"{choiceNum}. {option}");
  }
 }
 public int MakeChoice()
 {
  PrintOptions();
  int choice = 0;
  while (choice < 1 || choice > _options.Count())
  {
   try
   {
    _text.WriteLine("Choose an option:");
    choice = Convert.ToInt32(Console.ReadLine());
   }
   catch
   {
    Console.Write("Enter a number and make sure to ");
   }
   if (choice > 0 && choice <= _options.Count())
   {
    break;
   }
   else
   {
    _text.WriteLine("Pick a number between 1 and " + _options.Count());
   }
  }
  return choice;
 }
}