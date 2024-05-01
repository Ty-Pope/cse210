using System;

class Program
{
 static void Main(string[] args)
 {
  Job job1 = new Job();
  job1._jobTitle = "Software Engineer";
  job1._company = "Microsoft";
  job1._startYear = 1999;
  job1._endYear = 2004;
  job1.Display();
  Job job2 = new Job();
  job2._jobTitle = "Plumber";
  job2._company = "Apple";
  job2._startYear = 2004;
  job2._endYear = 2024;
  job2.Display();

  Resume resume1 = new Resume();
  resume1._name = "Tyler Pope";
  resume1._jobs = [job1, job2];
  resume1.Display();
 }
}