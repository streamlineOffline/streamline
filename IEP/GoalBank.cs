using System;
namespace IEP
{
    public class GoalBank
    {
        /*
         *im going to create an object that contains a parsing function "when given etc...."
         * im going to create a menu in main to identify each goal. the menu will be layered first layer will be math reading writting FSB
         * the next layer will level, the next layer will be sub area (problem solving calculations
         *
         * im going to be using one big string with a primary key and a parsing k "~M15The Goal is this~M16The Goal is this"]
         * ~ is the parsing key
         * M15 is the primary key 
         *
         * 
         */
        private string bank = "" +
            "~F1when given a regular school day the student will increase days of attendance by arriving to class on time and remaining in class for its entirety improving functional school behaviors from % to % as measured by attendance records." +
            "~F2when given a missing assignment report the student will reduce their missing assignments by completing them improving functional school behaviors from % missing assignments to % missing assignments as measured by Skyward missing assignment data." +
            "~F3when given daily assignments the student will plan out their work for the day and complete it improving functional student behaviors from % to % as measured by weekly planner checks." +
            "~F4when given time to organize their binder and bag the student will organize to include homework in correct binders or folders, and bag will have no loose papers improving functional school behaviors from % organized to % organized as measured by weekly binder and bag checks.	" +
            "~F5when given independent class time the student will arrive on time, stay in seat, work quietly the entire time, and have brought work or a book improving functional school behaviors from % of the time to % of the time as measured by weekly time management report.	" +
            "~F6when given an assignment to complete the student will work on improving their grades through work completion improving functional school behaviors from % to % as measured by weekly grade reports." +
            "~M11when given a math assignment, quiz or test at the 4th grade level the student will solve math problems improving correct number sense problem solving from % to % as measured by curriculum based assessments.	" +
            "~M12when given a math assignment, quiz or test at the 4th grade level the student will calculate math problems improving correct number sense calculations from % to % as measured by curriculum based assessments.	" +
            "~M13when given a math assignment, quiz or test at the 4th grade level the student will solve math problems improving number sense computations from % to % as measured by curriculum based assessments.	" +
            "~M14when given a math assignment, quiz or test at the 4th grade level the student will apply math concepts improving correct number sense from % to % as measured by curriculum based assessments.	" +
            "~M15when given a math assignment, quiz or test at the 4th grade level the student will solve math problems improving correct number sense problem solving from % to % as measured by curriculum based assessments.	" +
            "~M21when given a math assignment, quiz or test at the 6th grade level the student will solve math problems improving correct rational numbers sense problem solving from % to % as measured by curriculum based assessments.	" +
            "~M22when given a math assignment, quiz or test at the 6th grade level the student will calculate math problems improving correct rational number sense calculations from % to % as measured by curriculum based assessment.	" +
            "~M23when given a math assignment, quiz or test at the 6th grade level the student will solve math problems improving correct rational numbers sense computation from % to % as measured by curriculum based assessments.	" +
            "~M24when given a math assignment, quiz or test at the 6th grade level the student will apply math concepts improving correct rational number sense from % to % as measured by curriculum based assessments.	" +
            "~M25when given a math assignment, quiz or test at the 6th grade level the student will solve math problems improving correct rational number sense problem solving from % to % as measured by curriculum based assessments.	" +
            "~M31when given a math assignment, quiz or test at the 8th grade level the student will solve math problems improving correct algebra expressions, equations and functions problem solving from % to % as measured by curriculum based assessments.	" +
            "~M32when given a math assignment, quiz or test at the 8th grade level the student will calculate math problems improving correct algebra expressions, equations and functions from  to % as measured by curriculum based assessments.	" +
            "~M33when given a math assignment, quiz or test at the 8th grade level the student will solve math problems improving correct algebra expressions, equations and function computation from % to % as measured by curriculum based assessments.	" +
            "~M34when given a math assignment, quiz or test at the 8th grade level the student will apply math concepts improving correct algebra expressions, equations and functions from % to % as measured by curriculum based assessments.	" +
            "~M35when given a math assignment, quiz or test at the 8th grade level the student will solve math problems improving correct algebra expressions, equations and functions problem solving from % to % as measured by curriculum based assessments.	" +
            "~M41when given a math assignment, quiz or test at the 9th grade level the student will solve math problems improving correct algebraic reasoning problem solving from % to % as measured by curriculum based assessments.	" +
            "~M42when given a math assignment, quiz or test at the 9th grade level the student will calculate math problems improving correct algebraic reasoning calculations from % to % as measured by curriculum based assessments.	" +
            "~M43when given a math assignment, quiz or test at the 9th grade level the student will solve math problems improving correct algebraic reasoning computations from % to % as measured by curriculum based assessments.	" +
            "~M44when given a math assignment, quiz or test at the 9th grade level the student will apply math concepts improving correct algebraic reasoning from % to % as measured by curriculum based assessments.	" +
            "~M45when given a math assignment, quiz or test at the 9th grade level the student will solve math problems improving correct algebraic reasoning problem solving from % to % as measured by curriculum based assessments.	" +
            "~M51when given a math assignment, quiz or test at the 10th grade level the student will solve math problems improving their correct algebraic reasoning problem solving from % to % as measured by curriculum based assessments.	" +
            "~M52when given a math assignment, quiz or test at the 10th grade level the student will calculate math problems improving correct algebraic reasoning calculations from % to % as measured by curriculum based assessments.	" +
            "~M53when given a math assignment, quiz or test at the 10th grade level the student will solve math problems improving correct algebraic reasoning computations from % to % as measured by curriculum based assessments.	" +
            "~M54when given a math assignment, quiz or test at the 10th grade level the student will apply algebraic concepts improving correct algebraic reasoning applications from % to % as measured by curriculum based assessments.	" +
            "~M55when given a math assignment, quiz or test at the 10th grade level the student will solve math problems improving correct algebraic problem solving from %  to % as measured by curriculum based assessments.	" +
            "~M61when given a math assignment, quiz or test at the 11th grade level the student will solve math problems improving correct geometric reasoning problem solving from % to % as measured by curriculum based assessments.	" +
            "~M62when given a math assignment, quiz or test at the 11th grade level the student will calculate math problems improving correct geometric reasoning from % to % as measured by curriculum based assessments.	" +
            "~M63when given a math assignment, quiz or test at the 11th grade level the student will solve math problems improving geometric reasoning computations from % to % as measured by curriculum based assessments.	" +
            "~M64when given a math assignment, quiz or test at the 11th grade level the student will apply math concepts improving correct geometric reasoning from % to % as measured by curriculum based assessments.	" +
            "~M65when given a math assignment, quiz or test at the 11th grade level the student will solve math problems improving correct geometric reasoning problem solving from % to % as measured by curriculum based assessments.	" +
            "~RC1when given a reading assignment, test, or quiz at the 4th grade level the student will read and correctly answer questions improving reading comprehension skills from % to % as measured by curriculum based assessments	" +
            "~RC2when given a reading assignment, test, or quiz at the 5th grade level the student will read and correctly answer questions improving reading comprehension skills from % to % as measured by curriculum based measurement.	" +
            "~RC3when given a reading assignment, test, or quiz at the 6th grade level the student will read and correctly answer questions improving reading comprehension skills from % to % as measured by curriculum based assessments.	" +
            "~RC4when given a reading assignment, test, or quiz at the 7th grade level the student will read and correctly answer questions improving reading comprehension skills from % to % as measured by by curriculum based assessments.	" +
            "~RC5when given a reading assignment, test, or quiz at the 8th grade level the student will read and correctly answer questions improving reading comprehension skills from % to % as measured by by curriculum based assessments.	" +
            "~RC6when given a reading assignment, test, or quiz at the (10th grade level-12th pick level) the student will read and correctly answer questions improving reading comprehension skills from % to % as measured by curriculum based assessments.	" +
            "~RF1when given three, one minute, oral cold timed readings at the (Insert) grade level the student will read fluently improving correctly read words per minute from % to % as measured by AIMS web fluency test.	" +
            "~W1when given a writing passage with errors the student will edit the passage improving writing skills from % errors to % errors as measured by by curriculum based measurement.	" +
            "~W2when given an employability form to complete the student will complete the form legibly, correct spelling, neat and accurate improving writing skills from % correct to % correct as measured by curriculum based measurement.	" +
            "~W3when given a topic to write about the student will follow the writing prompt and use proper conventions improving writing skills from % correct to % correct as measured by by curriculum based measurement.	" +
            "~W4when given a topic to write about the student will use the 5 steps to the writing process including: Step #1 pre-write, #2 rough draft, #3 editing, #4 revision and #5 final draft improving writing skills from using (0-5) steps of the writing process to (0-5) steps of the writing process as measured by curriculum based measurement.	" +
            "~W5when given a story starter, one minute to think and three minutes to write the student will complete the story with correct spelling, grammar and punctuation improving correct writing sequences from (starting point) to (desired point) as measured by AIMS web writing assessments.	" +
            "~W6when given in class writing assignment the student will will complete the assignment with correct spelling, grammar and punctuation improving correct writing sequences from (starting point) to (desired point) as measured by curriculum based assessments.	" +
            "~W7when given a writing assignment the student will complete the assignment using correct grammar improving correct grammar used from % to % as measured by curriculum based assessments.	" +
            "~W8when given a writing prompt the student will use pre-writes to organize thoughts and ideas before they write improving writing organizational skills from (starting point) to (ending point) as measured by curriculum based measurements.	" +
            "~W9when given a story starter, one minute to think and three minutes to write the student will complete the story using correct spelling improving total words spelled correctly from (starting point) to (desired point) as measured by AIMs web writing assessments.	" +
            "~W10when given in class writing assignment the student will complete the assignment using correct spelling improving total words spelled correctly from (starting point) to (ending point) as measured by curriculum based measurements.	" +
            "~W11when given a story starter, one minute to think and three minutes to write the student will complete the story improving total words written from (this many total words) to (increase in total words) as measured by AIMs web writing assessments.	" +
            "~W12when given in class writing assignment the student will complete the assignment improving total words written from (current total words) to (desired total words) as measured by curriculum based assessments.	" +
            "~W13when given a writing assignment to complete in class the student will follow the prompt using correct spelling, grammar and punctuation improving writing fluency from (staring point) to (ending point) as measured by curriculum based measurements.			";
        public GoalBank()
        {
            
        }
        public string getGoal(string pkey)
        {
            string[] parse = this.getBank().Split('~');

            for (int i = 0; i < parse.Length; i++)
            {
                if (parse[i].Contains(pkey))
                {
                    return parse[i].Remove(0,pkey.Length);
                }
            }
            return "Pirmary Key does not mathc goal bank..\n..\n..\n..\n..";
        }
        public string getBank()
        {
            return bank;
        }
     

    }
}
