using System;

public class Entry
{
 private string time;
 private string prompt;
 private string response;
 public Entry(string time, string prompt, string response)
 {
  this.time = time;
  this.prompt = prompt;
  this.response = response;
 }

 public string getTime()
 {
  return time;
 }
 public string getPrompt()
 {
  return prompt;
 }
 public string getResponse()
 {
  return response;
 }
}