using System;
using System.Collections.Generic;
namespace IEP
{
    public class Student
    {
        
        public string FirstName { get; private set; }
        public string LastName { get; private set; }
        public string HisHer { get; private set; }
        public List<AreasOfSped> SDI;
        public List<string> PreviouseGoal { get; private set; }
        public List<string> NextGoal { get; private set; }
        public string Strengths { get; private set; }
        public List<Classes> Schedule;
        public Transition TransTab;

        
        public Student(string firstName, string lastName,string hisHer, List<AreasOfSped> sdi, List<string> previouseGoal, List<string> nextGoal, string strenghs, Transition transTab, List<Classes> schedule)
        {
            FirstName = firstName;
            LastName = lastName;
            HisHer = hisHer;
            SDI = sdi;
            PreviouseGoal = previouseGoal;
            NextGoal = nextGoal;
            Strengths = strenghs;
            TransTab = transTab;
            Schedule = schedule;

        }
        public Student() { }


        public List<string> teacherReports()
        {
            List<string> reports = new List<string>();
            string input = "";
            while (true)
            {
                Console.Write("Add teacher reports? (y/n) ");
                input = Console.ReadLine();
                input.ToLower();
                if (input == "y")
                {
                    Console.WriteLine("Add teacher report: (Name, class: report) ");
                    string report = Console.ReadLine();
                    reports.Add(report);
                }
                else if (input == "n")
                {
                    return reports;
                }
                else
                {
                    Console.WriteLine("you wrote '" + input + "', Please use 'y' or 'n'");
                }
            }
        }
        public void transNarrative(string firstName, string year, Student student)
        {
            switch (year)
            {
                case "9":
                    tenthGradePlan(firstName,student);
                    eleventhGradePlan(firstName, student);
                    twelvethGradePlan(firstName, student);
                    break;
                case "10":
                    eleventhGradePlan(firstName, student);
                    twelvethGradePlan(firstName, student);
                    break;
                case "11":
                    twelvethGradePlan(firstName, student);
                    break;
                default:
                    break;

            }
        }
        public void tenthGradePlan(string firstName, Student student)
        {
            string english = "English 10";
            string math = "Geometry";
            string electiveOrResource = "Elective";

            for (int i = 0; i < student.Schedule.Count; i++)
            {
                if (Schedule[i].Subject.Contains("asic"))
                {
                    english = "Basic Ed English 10 or English 10";
                }
                else if (Schedule[i].Subject.Contains("anguage"))
                {
                    if (Schedule[i].Subject.Contains("D"))
                    {
                        english = "Basic Ed English 10";
                    }
                    else
                    {
                        english = "Language D";
                    }
                }
                if (Schedule[i].Subject.Contains("3"))
                {
                    math = "Modified Algebra A";
                }
                else if (Schedule[i].Subject.Contains("2"))
                {
                    math = "Math 3";
                }
                else if (Schedule[i].Subject.Contains("1"))
                {
                    math = "Math 2";
                }
                else if (Schedule[i].Subject.Contains("A"))
                {
                    math = "Modified Alg B";
                }
                else if (Schedule[i].Subject.Contains("Pre"))
                {
                    math = "Algebra One";
                }
                if (Schedule[i].Subject.Contains("esource"))
                {
                    electiveOrResource = "Resource";
                }
            }
            Console.WriteLine("As a  10th grader, " + firstName + " should enroll in the following classes to meet graduation requirements and also to pursue post-secondary interests:\n\n10th");
            Console.WriteLine(english + "\n" + math + "\n" + electiveOrResource + "\nWorld History\nSecond Year Science\nElective or Foriegn Language");
        }
        public void eleventhGradePlan(string firstName, Student student)
        {
            string english = "English 11";
            string math = "Algebra Two";
            string electiveOrResource = "Elective";

            for (int i = 0; i < student.Schedule.Count; i++)
            {
                if (Schedule[i].Subject.Contains("Basic"))
                {
                    english = "Basic Ed English 11 or Englsih 11";
                }
                else if (Schedule[i].Subject.Contains("anguage"))
                {
                    if (Schedule[i].Subject.Contains("D"))
                    {
                        english = "Basic Ed English 11";
                    }
                    else
                    {
                        english = "Language D";
                    }
                }
                if (Schedule[i].Subject.Contains("3"))
                {
                    math = "Modified Algebra A";
                }
                else if (Schedule[i].Subject.Contains("2"))
                {
                    math = "Math 3";
                }
                else if (Schedule[i].Subject.Contains("1"))
                {
                    math = "Math 2";
                }
                else if (Schedule[i].Subject.Contains(" A"))
                {
                    math = "Modified Algebra B";
                }
                else if (Schedule[i].Subject.Contains("lgebra One"))
                {
                    math = "Algebra Two";
                }
                if (Schedule[i].Subject.Contains("esource"))
                {
                    electiveOrResource = "Resource";
                }
            }
            Console.WriteLine("As a  11th grader, " + firstName + " should enroll in the following classes to meet graduation requirements and also to pursue post-secondary interests:\n\n11th");
            Console.WriteLine(english + "\n" + math + "\n" + electiveOrResource + "\nUS History\nThird Year Science\nElective (CTE, Fine Arts, Foreign Language, PE)");
        }

        public void twelvethGradePlan(string firstName, Student student)
        {
            
            string electiveOrResource = "Elective";

            for (int i = 0; i < student.Schedule.Count; i++)
            {
          
                if (Schedule[i].Subject.Contains("esource"))
                {
                    electiveOrResource = "Resource";
                }
            }
            Console.WriteLine("As a  11th grader, " + firstName + " should enroll in the following classes to meet graduation requirements and also to pursue post-secondary interests:\n\n11th");
            Console.WriteLine(electiveOrResource + "\nEnglish 12\nCWP/Civics\nRemaining Required Credits");
        }


        public List<Goal> AddGoals()
        {
            string input = "";
            string subArea = "", prevGoal = "", status = "", nextGoal = "";
            List<Goal> goal = new List<Goal>();
            while (true)
            {
                Console.Write("Add goal? (y/n) ");
                input = Console.ReadLine();
                input.ToLower();
                if (input == "y")
                {
                    Console.Write("Sub Area: ");
                    subArea = Console.ReadLine();

                    Console.Write("Previous Goal: ");
                    prevGoal = Console.ReadLine();

                    Console.Write("Status: ");
                    status = Console.ReadLine();

                    Console.Write("Next Goal: ");
                    nextGoal = Console.ReadLine();

                    goal.Add(new Goal(subArea, prevGoal, status, nextGoal));
                }
                else if (input == "n")
                    return goal;
                else
                    Console.WriteLine("you wrote '" + input + "', Please use 'y' or 'n'");
            }
        }
        public string FindWord(string lookFor, string except, string phrase)
        {
            string[] parse = phrase.Split(' ');

            for (int i = 0; i < parse.Length; i++)
            {
                if (parse[i].Contains(lookFor) && (!parse[i].Contains(except)))
                {
                    return parse[i];

                }
            }
            return "0%";
        }
        public string FindPhrase(string lookFor, string phrase)
        {
            string[] parse = phrase.Split(' ');
            string subS = "";
            for (int k = 0; k < parse.Length; k++)
            {
                if (parse[k].Contains(lookFor))
                {
                    for(int i = k+1; i < parse.Length; i++)
                    {
                        subS += parse[i];
                        subS += " ";

                    }
                    return subS;
                }
            }
            return "0%";
        }
        public string listSDI(Student student)
        {
            string sdis = "";
            for (int i = 0; i < student.SDI.Count; i++)
            {
                if (student.SDI.Count > 2 && i > 0 && i < student.SDI.Count)
                {
                    if (i == student.SDI.Count - 1)
                    {
                        sdis += ", and ";
                    }
                    else
                    {
                        sdis += ", ";
                    }
                }
                else if (i > 0)
                {
                    sdis += " ";
                }
                else if (student.SDI.Count == 2 && i == 1)
                {
                    sdis += " and ";
                }
                sdis += student.SDI[i].SDI;

            
            }

            return sdis;
        }
    }
}
