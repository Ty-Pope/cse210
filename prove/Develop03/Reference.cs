
using System;

public class Reference
{
 private string text;
 private List<Word> words;
 public Reference(String text)
 {
  this.text = text;
  words = new List<Word>();
 }
 private void CreateWords()
 {
  List<String> wordsList = text.Split(' ').ToList();
  foreach (String word in wordsList)
  {
   words.Add(new Word(word, false));
  }
 }
 public bool HideWords(int count)
 {
  Random random = new();
  for (int i = 0; i < count; i++)
  {
   if (AllHidden())
   {
    return true;
   }
   int randomNumber = random.Next(1, words.Count);
   if (words[randomNumber].GetHiddenStatus() == false)
   {
    words[randomNumber].HideWord();
   }
   else
   {
    bool found = false;
    for (int j = randomNumber; j < words.Count; j++)
    {
     if (words[j].GetHiddenStatus() == false)
     {
      found = true;
      words[j].HideWord();
      break;
     }
    }
    if (!found)
    {
     for (int j = 0; j < randomNumber; j++)
     {
      if (words[j].GetHiddenStatus() == false)
      {
       words[j].HideWord();
       break;
      }
     }
    }
   }
  }
  return false;
 }

 public bool AllHidden()
 {
  foreach (Word word in words)
  {
   if (word.GetHiddenStatus() == false)
   {
    return false;
   }
  }
  return true;
 }

 public override string ToString()
 {
  if (words.Count == 0)
  {
   CreateWords();
  }
  List<string> wordsList = new List<string>();
  foreach (Word word in words)
  {
   wordsList.Add(word.GetText());
  }
  String text = "";
  foreach (String word in wordsList)
  {
   text += word + " ";
  }
  return text;
 }
}