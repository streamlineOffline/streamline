using System;
namespace IEP
{
    public class Goal
    {
        public string SubArea { get; private set; }
        public string PreviousGoal { get; private set; }
        public string NextGoal { get; private set; }
        public string Status { get; private set; }

        public Goal(string subArea, string previousGoal, string status, string nextGoal)
        {
            SubArea = subArea;
            PreviousGoal = previousGoal;
            Status = status;
            NextGoal = nextGoal;
        }
    }
}
