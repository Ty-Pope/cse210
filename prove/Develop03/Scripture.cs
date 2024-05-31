public class Scripture
{
 private string book;
 private int chapter;
 private int verseStart;
 private int verseEnd;
 private bool userQuit = false;
 private Reference text;
 public Scripture(string book, int chapter, int verseStart, Reference text)
 {
  this.book = book;
  this.chapter = chapter;
  this.verseStart = verseStart;
  this.text = text;
 }
 public Scripture(string book, int chapter, int verseStart, int verseEnd, Reference text)
 {
  this.book = book;
  this.chapter = chapter;
  this.verseStart = verseStart;
  this.verseEnd = verseEnd;
  this.text = text;
 }

 public void Practice()
 {
  bool isFinished = false;
  do
  {
   isFinished = getInput();
  }
  while (!isFinished);

  if (!userQuit)
  {
   Console.WriteLine($"{book} {chapter}:{verseStart} {text.ToString()}");
   Console.WriteLine("Press enter to exit.");
   Console.ReadLine();
  }
 }

 private bool getInput()
 {
  PrintScripture();
  Console.WriteLine("Press enter to hide the scripture or type 'quit' to exit.");
  string hide = Console.ReadLine();
  Console.Clear();
  if (hide.ToUpper() == "QUIT")
  {
   Console.WriteLine("Goodbye!");
   userQuit = true;
   return true;
  }
  else if (hide != "")
  {
   return false;
  }
  else
  {
   return text.HideWords(3);
  }
 }
 private void PrintScripture()
 {
  if (verseEnd == 0)
  {
   Console.WriteLine($"{book} {chapter}:{verseStart} {text.ToString()}");
  }
  else
  {
   Console.WriteLine($"{book} {chapter}:{verseStart}-{verseEnd} {text.ToString()}");
  }
 }
}