using System;

public class Listing : Activities
{
 public void BeginList()
 {
  BeginningMessage("Listing", "reflect on the good things in your life by listing as many things as you can in a certain area. You will be given a prompt and then list as many items as you can in the duration");
  SetDuration();
  string prompt = GetPrompt();
  Console.WriteLine(prompt);
  Countdown(5, prompt);
  int count = 0;

  DateTime futureTime = DateTime.Now.AddSeconds(GetDuration());

  while (DurationComplete(futureTime))
  {
   Console.WriteLine("Write an answer:");
   Console.ReadLine();
   count++;
  }
  EndMessage($"Listing. You listed {count} items");
 }
 public string GetPrompt()
 {
  string[] prompts = ["Who are people that you appreciate?", "What are personal strengths of yours?", "Who are people that you have helped this week?", "Who are some of your personal heroes?", "What are things on your bucket list?"];
  Random rnd = new();
  return prompts[rnd.Next(prompts.Length)];
 }
}