

using System;

public class Activities
{
 private int duration;
 protected void EndMessage(string activity)
 {
  Countdown(5, "Good job finishing the activity!");
  Console.WriteLine($"You have completed {activity}. You spent {duration} seconds on it. The program will now redirect you back to the menu.");
  Thread.Sleep(5000);
  CircleLoader();
 }
 protected void SetDuration()
 {
  Console.WriteLine("Enter how long you want an activity to be (in seconds):");
  this.duration = int.Parse(Console.ReadLine());
  Console.WriteLine($"Duration set to {duration} seconds.");
 }
 protected void BeginningMessage(string activity, string description)
 {
  Console.WriteLine($"You have picked {activity}. In this activity you will {description}.");
 }
 protected int GetDuration()
 {
  return this.duration;
 }
 private void CircleLoader()
 {
  Console.Write("                   ooo OOO OOO ooo\n");
  Console.Write("              oOO                 OOo\n");
  Console.Write("          oOO                         OOo\n");
  Console.Write("       oOO                               OOo\n");
  Console.Write("     oOO                                   OOo\n");
  Console.Write("   oOO                                       OOo\n");
  Console.Write("  oOO                                         OOo\n");
  Console.Write(" oOO                                           OOo\n");
  Console.Write("oOO                                             OOo\n");
  Console.Write("oOO                                             OOo\n");
  Console.Write("oOO                                             OOo\n");
  Console.Write("oOO                                             OOo\n");
  Console.Write("oOO                                             OOo\n");
  Console.Write(" oOO                                           OOo\n");
  Console.Write("  oOO                                         OOo\n");
  Console.Write("   oOO                                       OOo\n");
  Console.Write("     oOO                                   OOo\n");
  Console.Write("       oO                                OOo\n");
  Console.Write("          oOO                         OOo\n");
  Console.Write("              oOO                 OOo\n");
  Console.Write("                  ooo OOO OOO ooo");
  Thread.Sleep(1000);
  Console.Clear();

  Console.Write("                   ooo OOO OOO ooo\n");
  Console.Write("              oOO                 OOo\n");
  Console.Write("          oOO                         OOo\n");
  Console.Write("       oOO                               OOo\n");
  Console.Write("     oOO                                   OOo\n");
  Console.Write("   oOO                                       OOo\n");
  Console.Write("  oOO                                         OOo\n");
  Console.Write(" oOO                                           OOo\n");
  Console.Write("oOO                                             OOo\n");
  Console.Write("oOO                                             OOo\n");
  Console.Write("oOO                                             OOo\n");
  Console.Write("oOO                                             OOo\n");
  Console.Write("oOO                                             OOo\n");
  Console.Write(" oOO                                           OOo\n");
  Console.Write("  oOO                                         OOo\n");
  Console.Write("   oOO                                       OOo\n");
  Console.Write("     oOO                                   OOo\n");
  Console.Write("       oO                                OOo\n");
  Console.Write("          oOO                         OOo\n");
  Console.Write("              oOO██████████████████OOo\n");
  Console.Write("                  ooo OOO OOO ooo");
  Thread.Sleep(1000);
  Console.Clear();
  Console.Write("                   ooo OOO OOO ooo\n");
  Console.Write("              oOO                 OOo\n");
  Console.Write("          oOO                         OOo\n");
  Console.Write("       oOO                               OOo\n");
  Console.Write("     oOO                                   OOo\n");
  Console.Write("   oOO                                       OOo\n");
  Console.Write("  oOO                                         OOo\n");
  Console.Write(" oOO                                           OOo\n");
  Console.Write("oOO                                             OOo\n");
  Console.Write("oOO                                             OOo\n");
  Console.Write("oOO                                             OOo\n");
  Console.Write("oOO                                             OOo\n");
  Console.Write("oOO                                             OOo\n");
  Console.Write(" oOO                                           OOo\n");
  Console.Write("  oOO                                         OOo\n");
  Console.Write("   oOO                                       OOo\n");
  Console.Write("     oOO                                   OOo\n");
  Console.Write("       oO██████████████████████████████████OOo\n");
  Console.Write("          oOO██████████████████████████OOo\n");
  Console.Write("              oOO██████████████████OOo\n");
  Console.Write("                  ooo OOO OOO ooo");
  Thread.Sleep(1000);
  Console.Clear();
  Console.Write("                   ooo OOO OOO ooo\n");
  Console.Write("              oOO                 OOo\n");
  Console.Write("          oOO                         OOo\n");
  Console.Write("       oOO                               OOo\n");
  Console.Write("     oOO                                   OOo\n");
  Console.Write("   oOO                                       OOo\n");
  Console.Write("  oOO                                         OOo\n");
  Console.Write(" oOO                                           OOo\n");
  Console.Write("oOO                                             OOo\n");
  Console.Write("oOO                                             OOo\n");
  Console.Write("oOO                                             OOo\n");
  Console.Write("oOO                                             OOo\n");
  Console.Write("oOO                                             OOo\n");
  Console.Write(" oOO                                           OOo\n");
  Console.Write(" oOO████████████████████████████████████████████OOo\n");
  Console.Write("   oOO████████████████████████████████████████OOo\n");
  Console.Write("     oOO████████████████████████████████████OOo\n");
  Console.Write("        oO████████████████████████████████OOo\n");
  Console.Write("          oOO██████████████████████████OOo\n");
  Console.Write("              oOO██████████████████OOo\n");
  Console.Write("                  ooo OOO OOO ooo");
  Thread.Sleep(1000);
  Console.Clear();
  Console.Write("                   ooo OOO OOO ooo\n");
  Console.Write("              oOO                  OOo\n");
  Console.Write("          oOO                          OOo\n");
  Console.Write("       oOO                                OOo\n");
  Console.Write("     oOO                                    OOo\n");
  Console.Write("   oOO                                        OOo\n");
  Console.Write("  oOO                                          OOo\n");
  Console.Write(" oOO                                            OOo\n");
  Console.Write("oOO                                              OOo\n");
  Console.Write("oOO                                              OOo\n");
  Console.Write("oOO                                              OOo\n");
  Console.Write("oOO                                              OOo\n");
  Console.Write("oOO██████████████████████████████████████████████OOo\n");
  Console.Write(" oOO████████████████████████████████████████████OOo\n");
  Console.Write(" oOO████████████████████████████████████████████OOo\n");
  Console.Write("   oOO████████████████████████████████████████OOo\n");
  Console.Write("     oOO████████████████████████████████████OOo\n");
  Console.Write("        oO████████████████████████████████OOo\n");
  Console.Write("          oOO██████████████████████████OOo\n");
  Console.Write("              oOO██████████████████OOo\n");
  Console.Write("                  ooo OOO OOO ooo");
  Thread.Sleep(1000);
  Console.Clear();
  Console.Write("                   ooo OOO OOO ooo\n");
  Console.Write("              oOO                  OOo\n");
  Console.Write("          oOO                          OOo\n");
  Console.Write("       oOO                                OOo\n");
  Console.Write("     oOO                                    OOo\n");
  Console.Write("   oOO                                        OOo\n");
  Console.Write("  oOO                                          OOo\n");
  Console.Write(" oOO                                            OOo\n");
  Console.Write("oOO                                              OOo\n");
  Console.Write("oOO██████████████████████████████████████████████OOo\n");
  Console.Write("oOO██████████████████████████████████████████████OOo\n");
  Console.Write("oOO██████████████████████████████████████████████OOo\n");
  Console.Write("oOO██████████████████████████████████████████████OOo\n");
  Console.Write(" oOO████████████████████████████████████████████OOo\n");
  Console.Write(" oOO████████████████████████████████████████████OOo\n");
  Console.Write("   oOO████████████████████████████████████████OOo\n");
  Console.Write("     oOO████████████████████████████████████OOo\n");
  Console.Write("        oO████████████████████████████████OOo\n");
  Console.Write("          oOO██████████████████████████OOo\n");
  Console.Write("              oOO██████████████████OOo\n");
  Console.Write("                  ooo OOO OOO ooo");
  Thread.Sleep(1000);
  Console.Clear();
  Console.Write("                   ooo OOO OOO ooo\n");
  Console.Write("              oOO                  OOo\n");
  Console.Write("          oOO                          OOo\n");
  Console.Write("       oOO                                OOo\n");
  Console.Write("     oOO                                    OOo\n");
  Console.Write("   oOO████████████████████████████████████████OOo\n");
  Console.Write("  oOO██████████████████████████████████████████OOo\n");
  Console.Write(" oOO████████████████████████████████████████████OOo\n");
  Console.Write("oOO██████████████████████████████████████████████OOo\n");
  Console.Write("oOO██████████████████████████████████████████████OOo\n");
  Console.Write("oOO██████████████████████████████████████████████OOo\n");
  Console.Write("oOO██████████████████████████████████████████████OOo\n");
  Console.Write("oOO██████████████████████████████████████████████OOo\n");
  Console.Write(" oOO████████████████████████████████████████████OOo\n");
  Console.Write(" oOO████████████████████████████████████████████OOo\n");
  Console.Write("   oOO████████████████████████████████████████OOo\n");
  Console.Write("     oOO████████████████████████████████████OOo\n");
  Console.Write("        oO████████████████████████████████OOo\n");
  Console.Write("          oOO██████████████████████████OOo\n");
  Console.Write("              oOO██████████████████OOo\n");
  Console.Write("                  ooo OOO OOO ooo");
  Thread.Sleep(1000);
  Console.Clear();
  Console.Write("                   ooo OOO OOO ooo\n");
  Console.Write("              oOO                  OOo\n");
  Console.Write("          oOO███████████████████████████OOo\n");
  Console.Write("       oOO█████████████████████████████████OOo\n");
  Console.Write("     oOO████████████████████████████████████OOo\n");
  Console.Write("   oOO████████████████████████████████████████OOo\n");
  Console.Write("  oOO██████████████████████████████████████████OOo\n");
  Console.Write(" oOO████████████████████████████████████████████OOo\n");
  Console.Write("oOO██████████████████████████████████████████████OOo\n");
  Console.Write("oOO██████████████████████████████████████████████OOo\n");
  Console.Write("oOO██████████████████████████████████████████████OOo\n");
  Console.Write("oOO██████████████████████████████████████████████OOo\n");
  Console.Write("oOO██████████████████████████████████████████████OOo\n");
  Console.Write(" oOO████████████████████████████████████████████OOo\n");
  Console.Write(" oOO████████████████████████████████████████████OOo\n");
  Console.Write("   oOO████████████████████████████████████████OOo\n");
  Console.Write("     oOO████████████████████████████████████OOo\n");
  Console.Write("        oO████████████████████████████████OOo\n");
  Console.Write("          oOO██████████████████████████OOo\n");
  Console.Write("              oOO██████████████████OOo\n");
  Console.Write("                  ooo OOO OOO ooo");
  Thread.Sleep(1000);
  Console.Clear();
  Console.Write("                   ooo OOO OOO ooo\n");
  Console.Write("             oOO█████████████████████OOo\n");
  Console.Write("          oOO███████████████████████████OOo\n");
  Console.Write("       oOO█████████████████████████████████OOo\n");
  Console.Write("     oOO████████████████████████████████████OOo\n");
  Console.Write("   oOO████████████████████████████████████████OOo\n");
  Console.Write("  oOO██████████████████████████████████████████OOo\n");
  Console.Write(" oOO████████████████████████████████████████████OOo\n");
  Console.Write("oOO██████████████████████████████████████████████OOo\n");
  Console.Write("oOO██████████████████████████████████████████████OOo\n");
  Console.Write("oOO██████████████████████████████████████████████OOo\n");
  Console.Write("oOO██████████████████████████████████████████████OOo\n");
  Console.Write("oOO██████████████████████████████████████████████OOo\n");
  Console.Write(" oOO████████████████████████████████████████████OOo\n");
  Console.Write(" oOO████████████████████████████████████████████OOo\n");
  Console.Write("   oOO████████████████████████████████████████OOo\n");
  Console.Write("     oOO████████████████████████████████████OOo\n");
  Console.Write("        oO████████████████████████████████OOo\n");
  Console.Write("          oOO██████████████████████████OOo\n");
  Console.Write("              oOO██████████████████OOo\n");
  Console.Write("                  ooo OOO OOO ooo");
  Thread.Sleep(1000);
  Console.Clear();
 }
 protected void Countdown(int countLength, string display)
 {
  for (int i = countLength; i > 0; i--)
  {
   Console.Clear();
   Console.WriteLine(display);
   Console.WriteLine($"Countdown: {i}");
   Thread.Sleep(1000);
  }
 }

 //Returns false if duration is complete, returns true if time isn't over yet.
 protected bool DurationComplete(DateTime futureTime)
 {
  if (DateTime.Now > futureTime)
  {
   return false;
  }
  return true;
 }

 protected void SpinnerLoader(int countLength, string display)
 {
  string[] spinners = new string[] { "|", "/", "-", "\\" };
  for (int i = countLength; i > 0; i--)
  {
   Console.Clear();
   Console.WriteLine(display);
   Console.WriteLine(spinners[i % 4]);
   Thread.Sleep(1000);
  }
 }
}