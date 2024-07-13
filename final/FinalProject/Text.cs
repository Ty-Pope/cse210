public class Text
{
 public void WriteLine(string s, int sleep)
 {
  Write(s, sleep);
  Console.Write("\n");
 }
 public void WriteLine(Character c, string s, int sleep)
 {
  Write(c, s, sleep);
  Console.Write("\n");
 }
 public void Write(string s, int sleep)
 {
  foreach (char c in s)
  {
   Console.Write(c);
   Thread.Sleep((int)sleep);
  }
 }
 public void Write(Character c, string s, int sleep)
 {
  Console.Write(c.GetName() + ": ");
  Write(s, sleep);
 }
 public void Write(string s)
 {
  Write(s, 10);
 }
 public void Write(Character c, string s)
 {
  Write(c, s, 10);
 }
 public void WriteLine(string s)
 {
  WriteLine(s, 10);
 }
 public void WriteLine(Character c, string s)
 {
  WriteLine(c, s, 10);
 }
}