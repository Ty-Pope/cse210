

public class Word
{
 private String word;
 private bool isHidden;
 public Word(String word, bool isHidden)
 {
  this.word = word;
  this.isHidden = isHidden;
 }

 // Returns hidden or not hidden word
 public string HideWord()
 {
  isHidden = true;
  foreach (char letter in word)
  {
   if (letter != ' ')
   {
    word = word.Replace(letter, '_');
   }
  }
  return word;

 }
 public bool GetHiddenStatus()
 {
  return isHidden;
 }
 public string GetText()
 {
  return word;
 }
}