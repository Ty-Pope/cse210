using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

public class Journal
{
 private List<Entry> entries;
 private string path;
 private string fileName;
 private bool recentSave;
 public Journal(List<Entry> entries, string path, string fileName, bool recentSave)
 {
  this.entries = entries;
  this.path = path;
  this.fileName = fileName;
  this.recentSave = recentSave;
 }

 public string getFileName()
 {
  return fileName;
 }
 public bool getRecentSave()
 {
  return recentSave;
 }
 public void addEntry(Entry e)
 {
  entries.Add(e);
 }
 public void printEntries()
 {
  Console.WriteLine($"Journal Name: {fileName}");
  foreach (Entry entry in entries)
  {
   Console.WriteLine($"{entry.getTime()}, {entry.getPrompt()}\n{entry.getResponse()}");
  }
 }
 public void setPath(string path)
 {
  this.path = path;
 }
 public void load()
 {
  if (File.Exists(path))
  {
   using (StreamReader reader = new StreamReader(path))
   {
    string line;
    while ((line = reader.ReadLine()) != null)
    {
     string[] parts = line.Split("||,&12");
     if (parts.Length == 4)
     {
      string time = parts[0].Trim();
      string prompt = parts[1].Trim();
      string response = parts[2].Trim();
      string name = parts[3].Trim();
      Entry entry = new Entry(time, prompt, response);
      fileName = name;
      entries.Add(entry);
     }
    }
   }
   Console.WriteLine($"Journal loaded from: {path}");
  }
  else
  {
   while (!File.Exists(path))
   {
    Console.WriteLine($"Journal file not found at: {path}");
    Console.WriteLine("Please enter a path:");
    path = Console.ReadLine();
   }
  }
 }
 public void save()
 {
  if (string.IsNullOrEmpty(path))
  {
   Console.WriteLine("Please enter a path:");
   path = Console.ReadLine();
  }
  try
  {
   using (StreamWriter writer = new StreamWriter(path))
   {
    foreach (Entry entry in entries)
    {
     writer.WriteLine($"{entry.getTime()}||,&12{entry.getPrompt()}||,&12{entry.getResponse()}||,&12{fileName}");
    }
   }
   Console.WriteLine($"Journal saved to: {path}");
  }
  catch (Exception e)
  {
   Console.WriteLine($"Error saving journal: {e}.");
  }
 }
}