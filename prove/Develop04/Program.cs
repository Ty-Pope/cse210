using System;

class Program
{
 static void Main(string[] args)
 {
  Console.WriteLine("Welcome to this Mindfulness Program!");
  Activities act = new Activities();
  bool runAgain = true;
  List<string> activitiesPicked = new List<string>();
  while (runAgain)
  {
   Console.WriteLine("Pick an option: Breathe[B], List[L], Reflect[R], exit[E].");
   string option = Console.ReadLine();
   if (option.ToUpper() == "B")
   {
    Breathe b = new Breathe();
    b.BeginBreathe();
    activitiesPicked.Add("Breathe");
   }
   else if (option.ToUpper() == "L")
   {
    Listing l = new Listing();
    l.BeginList();
    activitiesPicked.Add("List");
   }
   else if (option.ToUpper() == "R")
   {
    Reflection r = new Reflection();
    r.BeginReflect();
    activitiesPicked.Add("Reflect");
   }
   else if (option.ToUpper() == "E")
   {
    break;
   }
  }
  int breatheCount = 0;
  int listCount = 0;
  int reflectCount = 0;
  foreach (string activity in activitiesPicked)
  {
   if (activity == "Breathe")
   {
    breatheCount++;
   }
   else if (activity == "List")
   {
    listCount++;
   }
   else if (activity == "Reflect")
   {
    reflectCount++;
   }
  }
  Console.WriteLine($"You did {breatheCount} Breathe activities, {listCount} List activities, and {reflectCount} Reflect activities.");
  Console.WriteLine("Goodbye!");
 }
}