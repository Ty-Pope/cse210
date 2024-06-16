public class Reflection : Activities
{
 public void BeginReflect()
 {
  BeginningMessage("Reflect", " reflect on times in your life when you have shown strength and resilience. This will help you recognize the power you have and how you can use it in other aspects of your life");
  SetDuration();
  DateTime futureTime = DateTime.Now.AddSeconds(GetDuration());

  while (DurationComplete(futureTime))
  {
   string prompt = GetPrompt();
   Console.WriteLine(prompt);
   SpinnerLoader(5, prompt);
   string followup = GetFollowup();
   Console.WriteLine(followup);
   SpinnerLoader(5, followup);
  }
  EndMessage("Reflect");
 }
 public string GetPrompt()
 {
  string[] prompts = ["Think of a time when you stood up for someone else.", "Think of a time when you did something really difficult.", "Think of a time when you helped someone in need.", "Think of a time when you did something truly selfless."];
  Random rnd = new();
  return prompts[rnd.Next(prompts.Length)];
 }

 public string GetFollowup()
 {
  string[] followups = ["How did you feel during this time?", "What did you learn from this experience?", "How did this experience change you?", "What would you do differently if you could go back in time?"];
  Random rnd = new();
  return followups[rnd.Next(followups.Length)];
 }
}