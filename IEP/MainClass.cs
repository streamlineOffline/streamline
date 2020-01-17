using System;
using System.Collections.Generic;

namespace IEP
{
    class MainClass
    {
      
        public static void Main(string[] args)
        {
            //add goal bank ... ooohhh sppoookyyy


            //------------------------------------------------Leave Alone-------------------------//
            List<AreasOfSped> SDI = new List<AreasOfSped>();
            List<string> PreviouseGoal = new List<string>();
            List<string> NextGoal = new List<string>();
            List<string> reports = new List<string>();
            List<Goal> rGoal = new List<Goal>();
            List<Goal> wGoal = new List<Goal>();
            List<Goal> fGoal = new List<Goal>();
            List<Goal> mGoal = new List<Goal>();
            List<Classes> Schedual = new List<Classes>();

            Classes c = new Classes();
            Student s = new Student();
            int sped = 0;
            string spedClass = "";
            string heShe;

            Console.Write("First Name:  ");
            string FirstName = Console.ReadLine();

            Console.Write("Last Name: ");
            string LastName = Console.ReadLine();

            Console.Write("Test Scores: ");
            string testing = Console.ReadLine();

            Console.Write("Strengths: ");
            string Strengths = Console.ReadLine();

            Console.Write("His or Her: ");
            string hisHer = Console.ReadLine();

            Console.Write("1st period: ");
            string class1 = Console.ReadLine();
            Console.Write("Class is Sped (T/F): ");
            bool isSped1 = c.isSpedClass();

            Console.Write("2nd period: ");
            string class2 = Console.ReadLine();
            Console.Write("Class is Sped (T/F): ");
            bool isSped2 = c.isSpedClass();

            Console.Write("3rd period: ");
            string class3 = Console.ReadLine();
            Console.Write("Class is Sped (T/F): ");
            bool isSped3 = c.isSpedClass();

            Console.Write("4th period: ");
            string class4 = Console.ReadLine();
            Console.Write("Class is Sped (T/F): ");
            bool isSped4 = c.isSpedClass();

            Console.Write("5th period: ");
            string class5 = Console.ReadLine();
            Console.Write("Class is Sped (T/F): ");
            bool isSped5 = c.isSpedClass();

            Console.Write("6th period: ");
            string class6 = Console.ReadLine();
            Console.Write("Class is Sped (T/F): ");
            bool isSped6 = c.isSpedClass();

            Console.Write("Transition section:\n\nPreference: Prefers to work in a enviornment where " + FirstName + " ...");
            string preference = Console.ReadLine();

            Console.Write("Interest: " + FirstName + " is interested in...");
            string interest = Console.ReadLine();

            Console.Write("Year: ");
            string year = Console.ReadLine();

            Console.Write("Credits: ");
            string credits = Console.ReadLine();

            Console.Write("Teacher Reports: ");
            reports = s.teacherReports();

            Console.WriteLine("Math: ");
            mGoal = s.AddGoals();
            if (mGoal.Count > 0)
                SDI.Add(new AreasOfSped("Math", mGoal));

            Console.WriteLine("Reading: ");
            rGoal = s.AddGoals();
            if (rGoal.Count > 0)
                SDI.Add(new AreasOfSped("Reading", rGoal));

            Console.WriteLine("Writing: ");
            wGoal = s.AddGoals();
            if (wGoal.Count > 0)
                SDI.Add(new AreasOfSped("Writting", wGoal));

            Console.WriteLine("FSB: ");
            fGoal = s.AddGoals();
            if (fGoal.Count > 0)
                SDI.Add(new AreasOfSped("Functional School Behaviors", fGoal));

            Transition TransTab = new Transition(preference, interest, year, credits);
            Schedual.Add(new Classes(isSped1, class1));
            Schedual.Add(new Classes(isSped2, class2));
            Schedual.Add(new Classes(isSped3, class3));
            Schedual.Add(new Classes(isSped4, class4));
            Schedual.Add(new Classes(isSped5, class5));
            Schedual.Add(new Classes(isSped6, class6));
            //----------//----------//---------//-----------//---------------//--------------//--------------//-----------//-----------//
            Console.WriteLine("\n\n-----------------------------------------" + FirstName + "'s IEP----------------------------------\n\n");
            //---------------------------------------------Leave Alone---------------------------//
            Student student = new Student(FirstName, LastName, hisHer, SDI, PreviouseGoal, NextGoal, Strengths, TransTab, Schedual);
            Console.WriteLine("Strength:\n\n" + student.Strengths + "\n\nConcerns: No concerns at this time \n");
            Console.WriteLine("Testing:\n" + testing + "\n");
            Console.WriteLine("Communication:\nThe IEP team Considered " + student.FirstName + "'s communication needs, " +
                "and this is not an area of concern at this time.\n");
            Console.WriteLine("Tech:\nThe IEP team Considered " + student.FirstName + "'s assistive technology needs, " +
                "and this is not an area of concern at this time.\n");
            Console.WriteLine("Behavioral:\nThe IEP team Considered " + student.FirstName + "'s behavioral needs, " +
                "and this is not an area of concern at this time.\n");
            Console.WriteLine("Language:\nThe IEP team Considered " + student.FirstName + "'s language technology needs, " +
                "and this is not an area of concern at this time.\n");
            Console.WriteLine("Braille:\nThe IEP team Considered " + student.FirstName + "'s need for braille instruction, " +
                "and this is not an area of concern at this time.\n");

            Console.WriteLine("Performance Tab:\n\n");
            for (int k = 0; k < student.SDI.Count; k++)
            {
                for (int i = 0; i < student.SDI[k].Goals.Count; i++)
                {
                    Console.WriteLine(student.SDI[k].Goals[i].SubArea + ":\n\n" + student.FirstName + "'s previous IEP Goal was: " + student.SDI[k].Goals[i].PreviousGoal +
               " According to progress report data on this goal, " + student.SDI[k].Goals[i].Status + " progress was demonstrated to meet this annual goal. " +
               "It is recommended that " + student.FirstName + "'s new goal be: " + student.SDI[k].Goals[i].NextGoal + " This will accommodate " + student.FirstName
               + "'s present " + student.SDI[k].Goals[i].SubArea + " levels, which were measured at " + student.FindWord("%", ".", student.SDI[k].Goals[i].NextGoal) + " according to " + student.FindPhrase("by", student.SDI[k].Goals[i].NextGoal) + "\n\n");
                }
            }

            Console.WriteLine("General Education:\n\n");
            Console.WriteLine(student.FirstName + "'s disabilities in " + student.listSDI(student) + " affect " + student.HisHer.ToLower() +
                " involvement and progress in the general education curriculum. " + student.FirstName +
                " is currently not able to access the curriculum at the same level as " + student.HisHer.ToLower() + " same age peers.\n\nTeacher Reports:\n\n");
            for (int i = 0; i < reports.Count; i++)
            {
                Console.WriteLine(reports[i] + "\n");
            }
            Console.WriteLine("Adverse Impact Summary:\n");
            Console.WriteLine(student.FirstName + "'s disabilities in " + student.listSDI(student) + " adversely affects " + student.HisHer.ToLower() +
                " involvement and progress in the general education curriculum. Continued deficits in " + student.listSDI(student) +
                " put the student at risk for academic failure if Specially Designed Instruction in these areas is not continued.\n\n");


            Console.WriteLine("Transistion:\n\n");
            Console.Write(student.FirstName + " needs SDI in " + student.listSDI(student) + ".\n\n");
            Console.WriteLine(student.FirstName + "'s Strengths:\n\n" + student.Strengths + "\n\n");
            Console.WriteLine(student.FirstName + " prefers to work in a environment where " + student.HisHer.ToLower() + " " + student.TransTab.Prefrences + "\n\n");
            Console.WriteLine(student.FirstName + " is interested in " + student.TransTab.Interest + "\n\n");
            Console.WriteLine(student.FirstName + " is a " + student.TransTab.Year + "th grader with " + student.TransTab.Credits +
                " credits. The focus of this year's schedule is working toward on-time graduation. At this time, " + student.HisHer.ToLower() +
                " schedule will focus on academics, and required classes needed for graduation. As " + student.FirstName + " explores " + student.HisHer.ToLower() + " career options and interest at the school "
                + student.HisHer.ToLower() + " schedule can be changed to more align with " + student.HisHer.ToLower() + " post secondary goals.\n\n");

            Console.WriteLine(student.TransTab.Year + "th");
            for (int i = 0; i < student.Schedule.Count; i++)
            {
                Console.WriteLine(student.Schedule[i].Subject);
            }
            // loop for the following years and potential classes
            student.transNarrative(FirstName, year, student);
            for (int i = 0; i < student.Schedule.Count; i++)
            { 
                if (student.Schedule[i].Sped == true)
                    {
                        sped++;
                    }  
            }
            for (int i = 0; i < student.Schedule.Count; i++)
            {
                
                if (student.Schedule[i].Sped)
                {
                    spedClass += student.Schedule[i].Subject;
                    if (sped >= 3)
                    {
                        if (i != student.Schedule.Count - 1)
                        {
                            spedClass += ", ";
                        }
                        else
                        {
                            spedClass += ", and ";
                        }
                    }
                    else if(sped == 2)
                    {
                        spedClass += " and ";
                    }
                    
                }
                
            }
           
            if (student.HisHer.Contains("is"))
            {
                heShe = "He";
            }
            else
            {
                heShe = "She";
            }
            //-----------------------------------------Services--------------------------------------------//
            //------------matrix
            double matrix = 53 * sped / student.SDI.Count;
            double wMatrix = 40 * sped / student.SDI.Count;
            Console.WriteLine("\n\n\n\n");
            //------------------------------------------top & bottom clean
            if (matrix * student.SDI.Count == 53 * sped)
            {
                Console.WriteLine("works");
                for (int i = 0; i < student.SDI.Count; i++)
                {
                    Console.WriteLine(student.SDI[i].SDI + ": " + matrix + " four times\t" + wMatrix + " one time\n");
                }
            }
            //------------------------------------------top .5 bottom clean
            else if(matrix - (int)matrix == ((double)1/2))
            {
                for (int i = 0; i < student.SDI.Count; i++)
                {
                    if (i + 1 <= student.SDI.Count / 2)
                    {
                        Console.Write(student.SDI[i].SDI + ": " + (int)matrix + 1 + " four times\t" + wMatrix + " one time\n");
                    }
                    else
                    {
                        Console.WriteLine(student.SDI[i].SDI + ": " + (int)matrix + " four times\t" + wMatrix + " one time\n");

                    }
                }
            }
            //------------------------------------------ top < .5
            else if (matrix - (int)matrix < ((double)1 / 2))
            {
                for (int i = 0; i < student.SDI.Count; i++)
                {
                    if (i == 0)
                    {
                  
                            // one day a week needs to be fixed for when the bottom is not whole refer to cheat sheet
                            Console.Write(student.SDI[i].SDI + ": " + (int)matrix + 1 + " four times\t" + wMatrix + " one time\n");
                    
                        Console.Write(student.SDI[i].SDI + ": " + (int)matrix + 1 + " four times\t" + wMatrix + " one time\n");
                    }
                    else
                    {
                        if (student.SDI.Count % 2 == 0)
                        {
                            // one day a week needs to be fixed for when the bottom is not whole refer to cheat sheet
                            Console.Write(student.SDI[i].SDI + ": " + (int)matrix + " four times\t" + wMatrix + " one time\n");
                        }
                        else
                        {                          
                            Console.Write(student.SDI[i].SDI + ": " + (int)matrix + " four times\t" + wMatrix + 1 + " one time\n");
                        }
                    }
                }
            }
            //------------------------------------------top > .5
            else if (matrix - (int)matrix > ((double)1 / 2))
            {
                for (int i = 0; i < student.SDI.Count; i++)
                {
                    if (i < student.SDI.Count -1)
                    {
                        // one day a week needs to be fixed for when the bottom is not whole refer to cheat sheet
                        Console.Write(student.SDI[i].SDI + ": " + (int)matrix + 1 + " four times\t" + wMatrix + " one time\n");
                    }
                    else
                    {
                        if (student.SDI.Count % 2 == 0)
                        {
                            // one day a week needs to be fixed for when the bottom is not whole refer to cheat sheet
                            Console.Write(student.SDI[i].SDI + ": " + (int)matrix + " four times\t" + wMatrix + " one time\n");
                        }
                        else
                        {
                            Console.Write(student.SDI[i].SDI + ": " + (int)matrix + " four times\t" + wMatrix + 1 + " one time\n");
                        }
                    }
                }
            }
            //------------------------------------------broke
            else
            {
                Console.WriteLine("Error: case does not exist...\ncheck the sdi and periods of sped...");
            }
            Console.WriteLine("\n\n\n\n");

            Console.WriteLine(student.FirstName + " is in " + sped.ToString() + " special education classes (" + spedClass + "). "
                + heShe + " will be in the general education environment for the rest of " + student.HisHer.ToLower() +
                " school day. The two time amounts for each area reflect the school's daily schedule. Wednesdays are a shorter day.\n\n");
           
            Console.WriteLine(student.FirstName + " qualifies for specially designed instruction in " + student.listSDI(student) + ". "
                + heShe + " is enrolled in " + sped.ToString() + "special education classes to support these goal areas. The remainder of "
                + student.HisHer.ToLower() + " academic day is in the general education setting with peers (&*%).\n\n" );
           // add service matrix student.areasOfSPed.matrix {"math 18/14}{reading 18/14}{func 17/15}
            Console.WriteLine("The school district is proposing to implement the IEP discussed at the IEP team meeting on 1/1/2020. Please see attached IEP.\n\n");
            
            Console.WriteLine(student.FirstName + " has been identified with a Specific Learning Disability, " +
                "and requires specially designed instruction in order to make sufficient progress.\n\n");
           
            Console.WriteLine("Psychology evaluation, amended three year evaluation, " +
                "Current IEP, transcript, Present levels, progress reports, academic assessment, " +
                "career interests, and transition goals. Parent(s) and student gave input.\n\n");
           
            Console.WriteLine("The following factors were discussed at the IEP meeting on 1/1/2020.\n\n");
        }
        
    }


}
