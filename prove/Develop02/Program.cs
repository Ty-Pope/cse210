using System;
using System.Collections.Generic;
using System.Globalization;
using System.Threading;

class Program
{
 static void Main(string[] args)
 {
  Journal j = new Journal(null, null, null, false);
  Console.WriteLine("Welcome to your personal journal!");
  while (true)
  {
   if (j.getFileName() != null)
   {
    Console.WriteLine("Would you like to write an entry [W], load a journal [J], save your journal [S], print your journal [P], or exit the program [E]?");
    string startInput = Console.ReadLine();
    if (startInput.ToUpper() == "W")
    {
     string prompt = givePrompt();
     Console.WriteLine(prompt);
     string response = Console.ReadLine();
     string now = DateTime.Now.ToString();
     Entry e = new Entry(now, prompt, response);
     j.addEntry(e);
     Console.WriteLine($"Entry added to {j.getFileName()}.");
    }
    else if (startInput.ToUpper() == "J")
    {
     Console.Write("Enter the path to the journal file: ");
     string path = Console.ReadLine();
     j.setPath(path);
     j.load();
    }
    else if (startInput.ToUpper() == "P")
    {
     j.printEntries();
    }
    else if (startInput.ToUpper() == "S")
    {
     j.save();
    }
    else if (startInput.ToUpper() == "E")
    {
     if (j.getRecentSave() == false)
     {
      Console.WriteLine("Would you like to save your journal before exiting? [Y/N]");
      string saveInput = Console.ReadLine();
      if (saveInput.ToUpper() == "Y")
      {
       j.save();
       Console.WriteLine("Goodbye!");
       break;
      }
      else if (saveInput.ToUpper() == "N")
      {
       Console.WriteLine("Goodbye!");
       break;
      }
     }
     else
     {
      Console.WriteLine("Goodbye!");
      break;
     }
    }
   }
   else
   {
    while (j.getFileName() == null)
    {
     Console.WriteLine("Would you like to create a new journal [C] or load a journal [L]?");
     string userInput = Console.ReadLine();
     if (userInput.ToUpper() == "C")
     {
      Console.Write("Give the journal a name: ");
      string name = Console.ReadLine();
      j = new Journal(new List<Entry>(), "", name, false);
     }
     else if (userInput.ToUpper() == "L")
     {
      Console.Write("Enter the path to the journal file: ");
      string path = Console.ReadLine();
      j = new Journal(new List<Entry>(), path, "", false);
      j.load();
     }
     else
     {
      Console.WriteLine("Please enter C or L");
     }
    }
   }
  }
 }
 public static string givePrompt()
 {
  List<string> prompts = new List<string> {
   "Reflect on a recent accomplishment and how it made you feel.",
   "Describe a moment of kindness you witnessed or experienced today.",
   "Write about a challenge you faced this week and how you overcame it.",
   "What are three things you're grateful for right now, and why?",
   "Recall a favorite childhood memory and explore why it's significant to you.",
   "Write a letter to your future self, discussing your current goals and aspirations.",
   "Describe a place you've always wanted to visit and why it intrigues you.",
   "Reflect on a mistake you made recently and what you learned from it."
  };
  Random random = new Random();
  return prompts[random.Next(0, prompts.Count)];
 }
}