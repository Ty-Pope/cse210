using System;

class Program
{
 static void Main(string[] args)
 {
  Console.WriteLine("Welcome to the scripture memorizer!");
  Scripture script = new Generator().ReturnScripture();
  script.Practice();
 }
}