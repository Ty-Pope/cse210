public class Breathe : Activities
{
 public void BeginBreathe()
 {
  BeginningMessage("Breathe", "relax by walking your through breathing in and out slowly. Clear your mind and focus on your breathing");
  SetDuration();
  DateTime futureTime = DateTime.Now.AddSeconds(GetDuration());
  while (DurationComplete(futureTime))
  {
   Countdown(5, "Breathe In...");
   Countdown(5, "Breathe Out...");
  }
  EndMessage("Breathe");
 }
}